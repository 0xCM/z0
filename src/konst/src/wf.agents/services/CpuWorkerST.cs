//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Diagnostics;

    using static z;

    using api = CpuWorkers;

    public struct CpuWorker<S,T>
        where S : struct
        where T : struct
    {
        internal CpuWorkerSettings Spec;

        internal Func<S,T> Projector;

        internal ITableExchange<S,T> Exchange;

        internal ProcessThread NativeThread;

        internal Thread ManagedThread;

        internal bool Continue;

        void Execute()
        {
            NativeThread = api.thread(CurrentProcess.OsThreadId);
            NativeThread.IdealProcessor = (int)Spec.Core;
            while(Continue)
            {
                var next = Exchange.Pull();
                if(!next.IsEmpty)
                {
                    var data = next.View;
                    var count = data.Length;
                    for(var i=0; i<count; i++)
                        Exchange.Push(Projector(skip(data,i)));
                }
                else
                {
                    Thread.Sleep(Spec.Frequency);
                }
            }
        }

        public void Run(IWfShell wf)
        {
            ManagedThread = new Thread(new ThreadStart(Execute));
            ManagedThread.IsBackground = true;
            ManagedThread.Name = Spec.Id.ToString();
            ManagedThread.Start();
        }
    }
}