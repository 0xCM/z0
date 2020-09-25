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

    /// <summary>
    /// Table process orchestrator
    /// </summary>
    public readonly ref struct TableDispatcher<F,T,D,S,Y>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum
        where S : unmanaged
    {
        /// <summary>
        /// The context in which the dispatcher is running
        /// </summary>
        internal readonly IWfShell Wf;

        /// <summary>
        /// The data source
        /// </summary>
        readonly Span<T> Source;

        /// <summary>
        /// The data target
        /// </summary>
        readonly Span<Y> Target;

        /// <summary>
        /// The table processors that define/apply target -> source projection
        /// </summary>
        readonly Span<TableMap<D,S,T,Y>> Processors;

        /// <summary>
        /// Processor selection keys
        /// </summary>
        readonly TableSectors<D,S> Selectors;

        uint SourceCount
            => (uint)Source.Length;

        [MethodImpl(Inline)]
        public TableDispatcher(IWfShell wf, T[] tables, TableMaps<D,S,T,Y> processors, TableSectors<D,S> selectors, Y[] dst)
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
            return Table.index(selector, Selectors.Offset);
        }

        /// <summary>
        /// Retrieves a D-identified projector vie the D/S selectors
        /// </summary>
        /// <param name="id">The projector identity</param>
        [MethodImpl(Inline)]
        public ref readonly TableMap<D,S,T,Y> Processor(D id)
        {
            ref readonly var selector = ref Selectors[id];
            var position = selector.Position;
            var idx = Index(id);
            ref readonly var p = ref skip(Processors, idx);
            return ref p;
        }
    }
}