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
    readonly ref struct TableDispatchEngine<F,T,K,I,Y>
        where F : unmanaged
        where T : struct, IKeyed<K>
        where K : unmanaged
        where I : unmanaged
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
        readonly Span<TableProjector<K,I,T,Y>> Projectors;

        /// <summary>
        /// Processor selection keys
        /// </summary>
        readonly IndexKeys<K,I> Selectors;

        uint SourceCount
            => (uint)Source.Length;

        [MethodImpl(Inline)]
        public TableDispatchEngine(IWfShell wf, T[] src, TableProjectors<K,I,T,Y> projectors, IndexKeys<K,I> selectors, Y[] dst)
        {
            Wf = wf;
            Source = src;
            Target = dst;
            Projectors = projectors.Edit;
            Selectors = selectors;
        }

        public void Dispose()
        {

        }

        [MethodImpl(Inline)]
        public void Run()
            => Dispatch(first(Source), ref first(Target), 0u, SourceCount);

        [MethodImpl(Inline)]
        public void Dispatch(in T src, ref Y dst, uint offset, uint count)
        {
            for(var i=offset; i<count; i++)
                Dispatch(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public ref Y Dispatch(in T src, ref Y dst)
        {
            dst = Projector(src.Key).Project(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref readonly Y Processed(K id)
            => ref skip(Target, Index(id));

        [MethodImpl(Inline)]
        public ulong Index(K id)
        {
            ref readonly var selector = ref Selectors[id];
            return index(selector, Selectors.Offset);
        }

        /// <summary>
        /// Retrieves a D-identified projector via the D/S selectors
        /// </summary>
        /// <param name="id">The projector identity</param>
        [MethodImpl(Inline)]
        public ref readonly TableProjector<K,I,T,Y> Projector(K id)
        {
            ref readonly var selector = ref Selectors[id];
            var position = selector.Index;
            var idx = Index(id);
            ref readonly var p = ref skip(Projectors, idx);
            return ref p;
        }

        [MethodImpl(Inline)]
        static ulong index(in IndexKey<K,I> selector, ulong offset)
            => uint64(selector.Index) - offset;
    }
}