//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
        
    /// <summary>
    /// Mediates access to a console process
    /// </summary>
    public class ProcessAdapter : IProcess
    {
        static bool IsExec(IMessage message)
            => message.Type == "exec";

        static FilePath NativeCommandProcessor
            => FilePath.Define("cmd.exe");

        static FilePath SelectedCommandProcessor
            => NativeCommandProcessor;

        public static ProcessAdapter ExecuteCmd
            (
                Action<MessagePacket> StandardReceiver,
                Action<MessagePacket> ErrorReceiver,
                Func<IMessage, IMessage> TransmissionInspector,
                FolderPath WorkingDirectory = null
            ) => ExecuteProcess(SelectedCommandProcessor,
                StandardReceiver,
                ErrorReceiver,
                TransmissionInspector,
                WorkingDirectory ?? FolderPath.Define(Environment.CurrentDirectory),
                "/K");
            

        public static ProcessAdapter ExecuteProcess
            (
                FilePath exepath,
                Action<MessagePacket> StandardReceiver,
                Action<MessagePacket> ErrorReceiver,
                Func<IMessage, IMessage> TransmissionInspector,
                FolderPath WorkingDirectory,
                params string[] initArgs
            ) => new ProcessAdapter(exepath.Name, StandardReceiver, ErrorReceiver, TransmissionInspector, 
                WorkingDirectory ?? FolderPath.Define(Environment.CurrentDirectory), initArgs);

        static void ConfigureStart(ProcessStartInfo si, FilePath exepath, FolderPath workdir, params string[] initArgs)
        {
            si.FileName = exepath.Name;
            si.Arguments = string.Join(" ", initArgs);
            si.RedirectStandardError = true;
            si.RedirectStandardInput = true;
            si.RedirectStandardOutput = true;
            si.CreateNoWindow = true;
            si.UseShellExecute = false;
            si.StandardErrorEncoding = Encoding.UTF8;
            si.StandardOutputEncoding = Encoding.UTF8;
            si.WorkingDirectory = workdir.Name;
        }

        Process AdaptedProcess { get; }

        Action<MessagePacket> StandardReceiver { get; }

        Action<MessagePacket> ErrorReceiver { get; }

        Func<IMessage,IMessage> TransmissionInspector { get; }

        ConcurrentQueue<IMessage> messages = new ConcurrentQueue<IMessage>();
        
        IMessage lastMessage;

        void Start()
        {
            AdaptedProcess.Start();
                
            Task.Factory.StartNew(RunStandardReceptionLoop)
                .ContinueWith(t => Console.WriteLine("Standard Reception Loop Terminated"));
            Task.Factory.StartNew(RunErrorReceptionLoop)
                .ContinueWith(t => Console.WriteLine("Error Reception Loop Terminated"));
            Task.Factory.StartNew(RunTransmissionLoop)
                .ContinueWith(t => Console.WriteLine("Dispatch Loop Terminated"));
        }

        ProcessAdapter(string exepath, Action<MessagePacket> StandardReceiver, Action<MessagePacket> ErrorReceiver, 
                Func<IMessage,IMessage> TransmisionInspector,
                FolderPath WorkingDirectory,
                params string[] initArgs
            )
        {
            AdaptedProcess = new Process();
            this.StandardReceiver = StandardReceiver;
            this.ErrorReceiver = ErrorReceiver;
            this.TransmissionInspector = TransmisionInspector;
            ConfigureStart(AdaptedProcess.StartInfo, FilePath.Define(exepath), WorkingDirectory, initArgs);
            AdaptedProcess.EnableRaisingEvents = true;
            AdaptedProcess.Exited += (sender, args) => Console.WriteLine($"Process exited");          
            Start();
        }
    
        enum Succeeded
        {
            No,
            Yes
        }

        static Succeeded Try(Action a, [CallerMemberName] string member = null)
        {
            try
            {
                a();
                return Succeeded.Yes;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error occurred in {member}: {e.Message}");
                return Succeeded.No;
            }
        }

        MessagePacket Pack(string payload)
            => new MessagePacket(
                CorrelationToken: lastMessage?.MessageId ?? Guid.Empty,
                Payload: payload,
                Label: 
                    (IsExec(lastMessage) && lastMessage.Payload.Contains(' ')) 
                    ? lastMessage.Payload.Split(' ').First() 
                    : lastMessage.Type
                );

        bool Running()
            => !AdaptedProcess.HasExited;

        Task<string> ErrorOutput
            => AdaptedProcess.StandardError.ReadLineAsync();

        Task<string> StandarOutput
            => AdaptedProcess.StandardOutput.ReadLineAsync();

        void RunStandardReceptionLoop()
        {
            try
            {
                while (Running()
                    && Try(() =>
                        StandardReceiver(Pack(StandarOutput.Result))) == Succeeded.Yes)
                {
                    //Yes, I'm empty
                }
            }
            catch(Exception e)
            {
                ErrorReceiver(Pack(e.ToString()));
            }
        }

        void RunErrorReceptionLoop()
        {
            while (Running()
                && Try(() => ErrorReceiver(Pack(ErrorOutput.Result))) == Succeeded.Yes)
            {
                //So am I

            }
        }

        public CorrelationToken Transmit(IMessage command)
        {
            var token = CorrelationToken.New();
            messages.Enqueue(z.stream(command, z.stream(new Message("",$"echo command {token} completed"))));
            return token;
        }

        public int ExitCode
            => AdaptedProcess.ExitCode;

        public int Id
            => AdaptedProcess.Id;

        public int WaitForExit()
        {
            AdaptedProcess.WaitForExit();
            return ExitCode;
        }

        void RunTransmissionLoop()
        {
            while (Running())
            {
                while (messages.TryDequeue(out IMessage m))
                {
                    try
                    {
                        lastMessage = m;
                        var text = IsExec(m) ? $"{m.Body}" : $"{m.Type} {m.Body}";
                        AdaptedProcess.StandardInput.WriteLine(text);
                        AdaptedProcess.StandardInput.Flush();
                        TransmissionInspector?.Invoke(m);
                    }
                    catch(Exception e)
                    {
                        TransmissionInspector?.Invoke(new Message("error", e.ToString()));
                    }

                }
                Task.Delay(1000).Wait();
            }
        }
    }
}