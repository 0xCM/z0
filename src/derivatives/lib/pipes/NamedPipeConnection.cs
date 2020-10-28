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

    using Z0.X.Events;

    public class NamedPipeConnection
    {
        NamedPipeServerStream ServerStream;

        NamedPipeStreamReader Reader;

        NamedPipeStreamWriter Writer;

        ITracer Tracer;

        Func<bool> IsStopping;

        public NamedPipeConnection(NamedPipeServerStream stream, ITracer tracer, Func<bool> isStopping)
        {
            ServerStream = stream;
            Tracer = tracer;
            IsStopping = isStopping;
            Reader = new NamedPipeStreamReader(ServerStream);
            Writer = new NamedPipeStreamWriter(ServerStream);
        }

        public bool IsConnected
        {
            get { return !IsStopping() && ServerStream.IsConnected; }
        }

        public PipeMessage ReadMessage()
        {
            return PipeMessage.from(this.ReadRequest());
        }

        public string ReadRequest()
        {
            try
            {
                return Reader.ReadMessage();
            }
            catch (IOException e)
            {
                EventMetadata metadata = new EventMetadata();
                metadata.Add("ExceptionMessage", e.Message);
                metadata.Add("StackTrace", e.StackTrace);
                this.Tracer.RelatedWarning(
                    metadata: metadata,
                    message: $"Error reading message from NamedPipe: {e.Message}",
                    keywords: EventKeys.Telemetry);

                return null;
            }
        }

        public virtual bool TrySendResponse(string message)
        {
            try
            {
                this.Writer.WriteMessage(message);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public bool TrySendResponse(PipeMessage message)
            => TrySendResponse(message.ToString());
    }
}