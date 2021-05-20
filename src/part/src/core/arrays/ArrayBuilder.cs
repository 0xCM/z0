//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    [ApiHost]
    public readonly struct ArrayBuilder
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ArrayBuilder<T> build<T>(int? capacity = null)
            => new ArrayBuilder<T>(capacity ?? 128);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ArrayBuilder<T> build<T>(params T[] src)
            => new ArrayBuilder<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void copy<T>(List<T> src, Span<T> dst)
        {
            var count = src.Count;
            ref var target = ref core.first(dst);
            for(var i=0; i<count; i++)
                core.seek(target,i) = src[i];
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] emit<T>(in ArrayBuilder<T> builder, bool clear = true)
        {
            var dst = builder.Storage.ToArray();
            if(clear)
                builder.Storage.Clear();
            return dst;
        }

        /// <summary>
        /// Copies the accumulated items to the target beginning at a specified offset
        /// </summary>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void copy<T>(List<T> src, uint offset, Span<T> dst)
        {
            var deposited = src.ViewDeposited();
            var count = deposited.Length;
            ref var target = ref core.seek(dst, offset);
            for(var i=offset; i<count; i++)
                core.seek(target,i) = core.skip(deposited, i);
        }
    }
}