//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    [ApiHost(ApiNames.ArrayBuilder, true)]
    public readonly struct ArrayBuilder
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArrayBuilder<T> build<T>(int? capacity = null)
            => new ArrayBuilder<T>(capacity ?? 128);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArrayBuilder<T> build<T>(params T[] src)
            => new ArrayBuilder<T>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void copy<T>(List<T> src, Span<T> dst)
        {
            var count = src.Count;
            ref var target = ref memory.first(dst);
            for(var i=0; i<count; i++)
                memory.seek(target,i) = src[i];
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void copy<T>(List<T> src, uint offset, Span<T> dst)
        {
            var count = src.Count;
            ref var target = ref memory.seek(dst, offset);
            for(var i=offset; i<count; i++)
                memory.seek(target,i) = src[(int)i];
        }
    }
}