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

    public readonly struct WfTableRunner<F,T,D,S,Y> : IDispatcher<F,T,D,S,Y>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum
        where S : unmanaged
    {
        public const string ActorName = nameof(WfTableRunner<F,T,D,S,Y>);
        
        public IWfContext Wf {get;}

        readonly WfTableMaps<D,S,T,Y> Processors;

        readonly Selectors<D,S> Selectors;

        readonly T[] Source;

        readonly Y[] Target;

        [MethodImpl(Inline)]
        public WfTableRunner(IWfContext wf, WfTableMaps<D,S,T,Y> processors, Selectors<D,S> selectors)
        {
            Wf = wf;
            Processors = processors;
            Selectors = selectors;
            Source = sys.empty<T>();
            Target = sys.empty<Y>();
            Wf.Created(ActorName);
        }

        [MethodImpl(Inline)]
        public WfTableRunner(IWfContext wf, WfTableMaps<D,S,T,Y> processors, Selectors<D,S> selectors, T[] src, Y[] dst)
        {
            Wf = wf;
            Processors = processors;
            Selectors = selectors;
            Source = src;
            Target = dst;
            Wf.Created(ActorName);
        }

        [MethodImpl(Inline)]
        public void Process(T[] src, Y[] dst)
        {
            Wf.Running(ActorName);
            var dispatcher = new WfTableDispatcher<F,T,D,S,Y>(Wf, src, Processors, Selectors, dst);
            dispatcher.Run();
            Wf.Ran(ActorName);            
        }

        [MethodImpl(Inline)]
        public void Run()
        {
            Process(Source,Target);
        }

        public void Dispose()
        {
            Wf.Finished(ActorName);
        }
    }
}