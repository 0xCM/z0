//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class Interpreter<H> : IWfService<H>, IDisposable
        where H : Interpreter<H>, new()
    {
        protected virtual void Initialized()
        {

        }

        protected virtual void OnExit()
        {

        }

        protected Interpreter()
        {
            OutputBuffer = new StringBuilder();
        }

        StringBuilder OutputBuffer {get;}

        protected IWfShell Wf {get; private set;}

        IWfProcLog Log;

        Process Worker;

        protected virtual string StartupArgs {get;}
            = EmptyString;

        protected abstract FS.FilePath ExePath {get;}

        public void Init(IWfShell wf)
        {
            Wf = wf;
            Log = WfLogs.process(WfLogs.configure(wf.Controller.Id, "processes"));

            var start = new ProcessStartInfo(ExePath.Name, StartupArgs)
            {
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                ErrorDialog = false,
                CreateNoWindow = true,
                RedirectStandardInput = true,

            };

            Worker = new Process();
            Worker.StartInfo = start;
            Worker.OutputDataReceived += OnStatus;
            Worker.ErrorDataReceived += OnError;
            Worker.EnableRaisingEvents = true;
            Worker.Exited += Exited;
        }

        void Exited(object sender, EventArgs e)
        {

        }


        void OnStatus(object sender, DataReceivedEventArgs e)
        {
            Log?.LogStatus(e.Data);
        }

        void OnError(object sender, DataReceivedEventArgs e)
        {
            Log?.LogStatus(e.Data);
        }

        public void Post(string command)
        {
            Worker.StandardInput.Write(command);
        }

        public Outcome Start()
        {
            try
            {
                Worker.Start();
                Worker.BeginOutputReadLine();
                Worker.BeginErrorReadLine();
                return true;

            }
            catch(Exception e)
            {
                return e;
            }
        }

        public void Dispose()
        {
            if(Worker != null)
                Worker.Close();

            if(Log != null)
                Log.Dispose();
        }
    }
}