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

        public T[] Source {get;}

        public Y[] Target {get;}

        readonly TableProcessors<D,S,T,Y> Processors;

        readonly Selectors<D,S> Selectors;

        [MethodImpl(Inline)]
        public DispatcherProxy(IWfContext wf, T[] src, TableProcessors<D,S,T,Y> processors, Selectors<D,S> selectors, Y[] dst)
        {
            Wf = wf;
            Source = src;
            Processors = processors;
            Selectors = selectors;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public Span<Y> Process()
        {
            var dispatcher = new Dispatcher<F,T,D,S,Y>(Wf, Source, Processors, Selectors, Target);
            var input = span(Source);
            var output = span(Target);
            var count = Source.Length;

            dispatcher.Process();

            return dispatcher.Target;
        }
    }
}