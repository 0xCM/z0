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
    /// Defines a projection operator project:T[] -> Y[] where T conforms to <see cref='ITable'/> and Y is arbitrary
    /// </summary>
    public readonly struct TableProjector<D,S,T,Y> : ITableProjector<TableProjector<D,S,T,Y>, D,S,T,Y>
        where D : unmanaged
        where T : struct
        where S : unmanaged
    {
        public IndexKey<D,S> Id {get;}

        readonly Func<T,Y> Fx;

        [MethodImpl(Inline)]
        public TableProjector(Func<T,Y> f, IndexKey<D,S> id)
        {
            Id = id;
            Fx = f;
        }

        /// <summary>
        /// Projects a table onto a target
        /// </summary>
        /// <param name="x">The source table</param>
        [MethodImpl(Inline)]
        public Y Project(in T x)
            => Fx(x);

        /// <summary>
        /// Projects a source sequence onto a target sequence
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public Span<Y> Project(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            var dst = span<Y>(count);
            ref readonly var srcCell = ref first(src);
            ref var dstCell = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(dstCell,i) = Fx(skip(srcCell,i));
            return dst;
        }
    }
}