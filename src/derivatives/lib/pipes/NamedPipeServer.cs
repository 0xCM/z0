//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Pipes
{
    using System;
    using System.IO;
    using System.IO.Pipes;
    using System.Threading;
    using System.Security.AccessControl;
    using System.Security.Principal;

    using Z0.X.Events;

    /// <summary>
    /// The server side of a Named Pipe used for interprocess communication.
    ///
    /// Named Pipe protocol:
    ///    The client / server process sends a "message" (or line) of data as a
    ///    sequence of bytes terminated by a 0x3 byte (ASCII control code for
    ///    End of text). Text is encoded as UTF-8 to be sent as bytes across the wire.
    ///
    /// This format was chosen so that:
    ///   1) A reasonable range of values can be transmitted across the pipe,
    ///      including null and bytes that represent newline characters.
    ///   2) It would be easy to implement in multiple places, as we
    ///      have managed and native implementations.
    /// </summary>
    public class NamedPipeServer : IDisposable
    {
        const byte MaxPipePathLength = 250;

        public static NamedPipeServerStream pipe(string pipeName)
        {
            PipeSecurity security = new PipeSecurity();
            security.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), PipeAccessRights.ReadWrite | PipeAccessRights.CreateNewInstance, AccessControlType.Allow));
            security.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.CreatorOwnerSid, null), PipeAccessRights.FullControl, AccessControlType.Allow));
            security.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null), PipeAccessRights.FullControl, AccessControlType.Allow));

            NamedPipeServerStream pipe = NamedPipeServerStreamEx.Create(
                pipeName,
                PipeDirection.InOut,
                NamedPipeServerStream.MaxAllowedServerInstances,
                PipeTransmissionMode.Byte,
                PipeOptions.WriteThrough | PipeOptions.Asynchronous,
                0, // default inBufferSize
                0, // default outBufferSize
                security,
                HandleInheritability.None);

            return pipe;
        }

        bool IsStopping;

        string PipeName;

        Action<NamedPipeConnection> handleConnection;

        ITracer Tracer;

        NamedPipeServerStream listeningPipe;

        private NamedPipeServer(string pipeName, ITracer tracer, Action<NamedPipeConnection> handleConnection)
        {
            this.PipeName = pipeName;
            this.Tracer = tracer;
            this.handleConnection = handleConnection;
            this.IsStopping = false;
        }

        public static NamedPipeServer StartNewServer(string pipeName, ITracer tracer, Action<ITracer, string, NamedPipeConnection> handleRequest)
        {
            if (pipeName.Length > MaxPipePathLength)
            {
                throw new PipeNameLengthException(string.Format("The pipe name ({0}) exceeds the max length allowed({1})", pipeName, MaxPipePathLength));
            }

            NamedPipeServer pipeServer = new NamedPipeServer(pipeName, tracer, connection => HandleConnection(tracer, connection, handleRequest));
            pipeServer.OpenListeningPipe();

            return pipeServer;
        }

        public void Dispose()
        {
            this.IsStopping = true;

            NamedPipeServerStream pipe = Interlocked.Exchange(ref this.listeningPipe, null);
            if (pipe != null)
            {
                pipe.Dispose();
            }
        }

        private static void HandleConnection(ITracer tracer, NamedPipeConnection connection, Action<ITracer, string, NamedPipeConnection> handleRequest)
        {
            while (connection.IsConnected)
            {
                string request = connection.ReadRequest();

                if (request == null ||
                    !connection.IsConnected)
                {
                    break;
                }

                handleRequest(tracer, request, connection);
            }
        }

        private void OpenListeningPipe()
        {
            try
            {
                if (this.listeningPipe != null)
                {
                    throw new InvalidOperationException("There is already a pipe listening for a connection");
                }

                this.listeningPipe = NamedPipeServer.pipe(this.PipeName);
                this.listeningPipe.BeginWaitForConnection(this.OnNewConnection, this.listeningPipe);
            }
            catch (Exception e)
            {
                this.LogErrorAndExit("OpenListeningPipe caught unhandled exception, exiting process", e);
            }
        }

        private void OnNewConnection(IAsyncResult ar)
        {
            if (!this.IsStopping)
            {
                this.OnNewConnection(ar, createNewThreadIfSynchronous: true);
            }
        }

        private void OnNewConnection(IAsyncResult ar, bool createNewThreadIfSynchronous)
        {
            if (createNewThreadIfSynchronous &&
               ar.CompletedSynchronously)
            {
                // if this callback got called synchronously, we must not do any blocking IO on this thread
                // or we will block the original caller. Moving to a new thread so that it will be safe
                // to call a blocking Read on the NamedPipeServerStream

                new Thread(() => this.OnNewConnection(ar, createNewThreadIfSynchronous: false)).Start();
                return;
            }

            this.listeningPipe = null;
            bool connectionBroken = false;

            NamedPipeServerStream pipe = (NamedPipeServerStream)ar.AsyncState;
            try
            {
                try
                {
                    pipe.EndWaitForConnection(ar);
                }
                catch (IOException e)
                {
                    connectionBroken = true;

                    EventMetadata metadata = new EventMetadata();
                    metadata.Add("Area", "NamedPipeServer");
                    metadata.Add("Exception", e.ToString());
                    metadata.Add(MessageKeys.WarningMessage, "OnNewConnection: Connection broken");
                    this.Tracer.RelatedEvent(EventLevel.Warning, "OnNewConnectionn_EndWaitForConnection_IOException", metadata);
                }
                catch (Exception e)
                {
                    this.LogErrorAndExit("OnNewConnection caught unhandled exception, exiting process", e);
                }

                if (!this.IsStopping)
                {
                    this.OpenListeningPipe();

                    if (!connectionBroken)
                    {
                        try
                        {
                            this.handleConnection(new NamedPipeConnection(pipe, this.Tracer, () => this.IsStopping));
                        }
                        catch (Exception e)
                        {
                            this.LogErrorAndExit("Unhandled exception in connection handler", e);
                        }
                    }
                }
            }
            finally
            {
                pipe.Dispose();
            }
        }

        private void LogErrorAndExit(string message, Exception e)
        {
            if (this.Tracer != null)
            {
                EventMetadata metadata = new EventMetadata();
                metadata.Add("Area", "NamedPipeServer");
                if (e != null)
                {
                    metadata.Add("Exception", e.ToString());
                }

                this.Tracer.RelatedError(metadata, message);
            }

            Environment.Exit((int)ReturnCode.GenericError);
        }
    }
}