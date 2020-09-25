//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableRunner<F,T,D,S,Y> : ITableDispatcher<F,T,D,S,Y>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum
        where S : unmanaged
    {
        public const string StepName = nameof(TableRunner<F,T,D,S,Y>);

        public IWfShell Wf {get;}

        public WfStepId StepId
            => Flow.step(typeof(TableRunner<F,T,D,S,Y>));

        readonly TableMaps<D,S,T,Y> Processors;

        readonly TableSectors<D,S> Selectors;

        readonly T[] Source;

        readonly Y[] Target;

        [MethodImpl(Inline)]
        public TableRunner(IWfShell wf, TableMaps<D,S,T,Y> processors, TableSectors<D,S> selectors)
        {
            Wf = wf;
            Processors = processors;
            Selectors = selectors;
            Source = sys.empty<T>();
            Target = sys.empty<Y>();
            Wf.Created(StepId);
        }

        [MethodImpl(Inline)]
        public TableRunner(IWfShell wf, TableMaps<D,S,T,Y> processors, TableSectors<D,S> selectors, T[] src, Y[] dst)
        {
            Wf = wf;
            Processors = processors;
            Selectors = selectors;
            Source = src;
            Target = dst;
            Wf.Created(StepId);
        }

        [MethodImpl(Inline)]
        public void Process(T[] src, Y[] dst)
        {
            Wf.Running(StepId);
            var dispatcher = new TableDispatcher<F,T,D,S,Y>(Wf, src, Processors, Selectors, dst);
            dispatcher.Run();
            Wf.Ran(StepId);
        }

        [MethodImpl(Inline)]
        public void Run()
        {
            Process(Source,Target);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }
    }
}