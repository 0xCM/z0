//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    using static Konst;
    using static z;

    public abstract class Interpreter<H> : IWfShellService<H>, IDisposable
        where H : Interpreter<H>, new()
    {
        public static H create()
            => new H();

        public static H create(IWfShell wf)
        {
            var host = new H();
            host.Init(wf);
            return host;
        }

        protected Interpreter()
        {
            Name = typeof(H).Name;
            TermLog = WfLogs.term(Name);
            Frequency = new TimeSpan(0, 0, 0, 0, 50);
            Host = WfShell.host(typeof(H));
            CommandQueue = new ConcurrentQueue<string>();
            ExecLog = new ConcurrentDictionary<ulong,WfExecToken>();
            DispatchKeys = new ConcurrentBag<Guid>();
            Tokenizer = WfShell.tokenizer();
            Running = false;
            Initialized = false;
        }

        public Name Name {get;}

        WfHost Host;

        IWfEventSink TermLog;

        Duration Frequency;

        bool Running;

        bool Initialized;

        WfTokenizer Tokenizer;

        readonly ConcurrentQueue<string> CommandQueue;

        readonly ConcurrentBag<Guid> DispatchKeys;

        readonly ConcurrentDictionary<ulong,WfExecToken> ExecLog;

        public void Submit(string command)
        {
            try
            {
                var key = Guid.NewGuid();
                DispatchKeys.Add(key);
                CommandQueue.Enqueue(string.Format("echo dispatching:{0}", key));
                CommandQueue.Enqueue(command);
                CommandQueue.Enqueue(string.Format("echo executed:{0}", key));
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        protected virtual string StartupArgs {get;}
            = EmptyString;

        protected abstract FS.FilePath ExePath {get;}

        protected IWfShell Wf {get; private set;}

        IWfProcLog WorkerLog;

        Process Worker;

        Task SpinTask;

        WfExecToken Token;

        public void Run()
        {
            if(!Initialized)
                throw new Exception("Not initialized!");

            Worker.Start();
            Worker.BeginOutputReadLine();
            Worker.BeginErrorReadLine();
            Running = true;
            SpinTask = task(() => Spin());
        }

        public void Init(IWfShell wf)
        {
            try
            {
                Wf = wf.WithHost(Host);
                WorkerLog = WfLogs.process(WfLogs.configure(wf.Controller.Id, wf.Db().Root, "processes"));
                Worker = new Process();

                var start = new ProcessStartInfo(ExePath.Name, StartupArgs)
                {
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    ErrorDialog = false,
                    CreateNoWindow = true,
                };

                Worker.StartInfo = start;
                Worker.OutputDataReceived += OnStatus;
                Worker.ErrorDataReceived += OnError;
                Worker.EnableRaisingEvents = true;
                Worker.Exited += Exited;
                Initialized = true;
            }
            catch(Exception e)
            {
                wf.Error(e);
                throw e;
            }
        }

        public abstract void SubmitStop();

        void Exited(object sender, EventArgs e)
        {
            Wf.Status("Process exit event received");
        }

        void OnStatus(object sender, DataReceivedEventArgs e)
        {
            if(e != null && e.Data != null)
            {
                WorkerLog?.LogStatus(e.Data);
                TermLog.Deposit(WfEvents.status(Host, e.Data, Wf.Ct));
            }
        }

        void OnError(object sender, DataReceivedEventArgs e)
        {
            if(e != null && e.Data != null)
            {
                WorkerLog?.LogError(e.Data);
                TermLog.Deposit(WfEvents.error(Host, e.Data, Wf.Ct));
            }
        }

        public void Dispose()
        {
            if(Worker != null)
                Worker.Close();

            if(WorkerLog != null)
                WorkerLog.Dispose();
        }

        void Dispatch()
        {
            if(Running)
            {
                if(CommandQueue.TryDequeue(out var cmd))
                {
                    var token = Tokenizer.Open();
                    ExecLog[token.StartSeq] = token;
                    Worker.StandardInput.WriteLine(cmd);
                    Dispatch();
                }
            }
        }

        void Spin()
        {
            while(true && Running)
            {
                Dispatch();
                delay(Frequency);
            }
        }

        public WfExecToken WaitForExit()
        {
            SubmitStop();
            Worker.WaitForExit();
            return Token;
        }
    }
}