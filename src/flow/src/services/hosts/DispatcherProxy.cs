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

    public readonly struct DispatcherProxy<F,T,D,S,Y> : IDispatcher<F,T,D,S,Y>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum
        where S : unmanaged
    {
        public IWfContext Wf {get;}

        readonly TableProcessors<D,S,T,Y> Processors;

        readonly Selectors<D,S> Selectors;

        [MethodImpl(Inline)]
        public DispatcherProxy(IWfContext wf, TableProcessors<D,S,T,Y> processors, Selectors<D,S> selectors)
        {
            Wf = wf;
            Processors = processors;
            Selectors = selectors;
        }

        [MethodImpl(Inline)]
        public void Process(T[] src, Y[] dst)
        {
            var dispatcher = new Dispatcher<F,T,D,S,Y>(Wf, src, Processors, Selectors, dst);
            dispatcher.Process();
        }
    }
}