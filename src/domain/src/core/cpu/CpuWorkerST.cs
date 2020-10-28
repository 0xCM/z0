//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Diagnostics;

    using static Konst;
    using static z;

    using api = CpuWorkers;

    public struct CpuWorker<S,T>
        where S : struct
        where T : struct

    {
        CpuWorkerSettings Spec;

        Func<S,T> Projector;

        ITableExchange<S,T> Exchange;

        ProcessThread NativeThread;

        Thread ManagedThread;

        bool Continue;

        public static CpuWorker<S,T> create(CpuWorkerSettings spec, Func<S,T> projector, ITableExchange<S,T> exchange)
        {
            var worker = new CpuWorker<S,T>();
            worker.Spec = spec;
            worker.Exchange = exchange;
            worker.Projector = projector;
            worker.Continue = true;
            return worker;
        }


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