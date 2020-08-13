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
    using api = Flow;
        
    public readonly ref struct WfTableDispatcher<F,T,D,S,Y>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum        
        where S : unmanaged
    {
        internal readonly IWfContext Wf;
        
        internal readonly Span<T> Source;

        internal readonly Span<Y> Target;

        internal readonly Span<WfTableMap<D,S,T,Y>> Processors;

        internal readonly Selectors<D,S> Selectors;

        internal uint SourceCount 
            => (uint)Source.Length;

        [MethodImpl(Inline)]
        public WfTableDispatcher(IWfContext wf, T[] tables, WfTableMaps<D,S,T,Y> processors, Selectors<D,S> selectors, Y[] dst)
        {
            Wf = wf;
            Source = tables;
            Target = dst;
            Processors = processors.Edit;
            Selectors = selectors;
        }

        [MethodImpl(Inline)]
        public void Run()
        {
            Map(first(Source), ref first(Target), 0u, SourceCount);                        
        }

        [MethodImpl(Inline)]
        public void Map(in T src, ref Y dst, uint offset, uint count)
        {
            for(var i=offset; i<count; i++)
                Map(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public ref Y Map(in T src, ref Y dst)
        {
            dst = Processor(src.Id).Map(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref readonly Y Processed(D id)
            => ref skip(Target, Index(id));

        [MethodImpl(Inline)]
        public ulong Index(D id)
        {
            ref readonly var selector = ref Selectors[id];                
            var position = selector.Position;
            return api.index(selector, Selectors.Offset);
        }
        
        [MethodImpl(Inline)]
        public ref readonly WfTableMap<D,S,T,Y> Processor(D id)
        {
            ref readonly var selector = ref Selectors[id];                
            var position = selector.Position;
            var idx = Index(id);
            ref readonly var p = ref skip(Processors, idx);
            return ref p;
        }
    }
}