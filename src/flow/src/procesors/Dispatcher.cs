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
    using api = TableProcessors;
        
    public readonly ref struct Dispatcher<F,T,D,S,Y>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum        
        where S : unmanaged
    {
        internal readonly IWfContext Wf;
        
        internal readonly Span<T> Source;

        internal readonly Span<Y> Target;

        internal readonly Span<TableProcessor<D,S,T,Y>> Processors;

        internal readonly Selectors<D,S> Selectors;

        internal uint SourceCount 
            => (uint)Source.Length;

        [MethodImpl(Inline)]
        public Dispatcher(IWfContext wf, T[] tables, TableProcessors<D,S,T,Y> processors, Selectors<D,S> selectors, Y[] dst)
        {
            Wf = wf;
            Source = tables;
            Target = dst;
            Processors = processors.Edit;
            Selectors = selectors;
        }

        [MethodImpl(Inline)]
        public void Process()
        {
            Process(first(Source), ref first(Target), 0u, SourceCount);                        
        }

        [MethodImpl(Inline)]
        public void Process(in T src, ref Y dst, uint offset, uint count)
        {
            for(var i=offset; i<count; i++)
                Process(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public ref Y Process(in T src, ref Y dst)
        {
            dst = Processor(src.Id).Process(src);
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
        public ref readonly TableProcessor<D,S,T,Y> Processor(D id)
        {
            ref readonly var selector = ref Selectors[id];                
            var position = selector.Position;
            var idx = Index(id);
            ref readonly var p = ref skip(Processors, idx);
            return ref p;
        }
    }
}