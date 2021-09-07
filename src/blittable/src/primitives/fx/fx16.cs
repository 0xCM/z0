//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Blit.Factory;

    partial struct Blit
    {
        /// <summary>
        /// Defines a function fx8:u8->T
        /// </summary>
        /// <param name="f">The function under specification</param>
        /// <param name="src">The source domain points</param>
        /// <param name="dst">The target domain points</param>
        /// <typeparam name="T">The target domain</typeparam>
        [Op, Closures(Closure)]
        public static ref fx16<ushort,T> fx<T>(N16 n, ref fx16<ushort,T> f, ReadOnlySpan<ushort> src, ReadOnlySpan<T> dst)
            where T : unmanaged
        {
            f.SrcMap.Clear();
            var count = min(min(src.Length, dst.Length), Blit.fx16<ushort,T>.Capacity);
            f.Size = (uint)count;
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(src,i);
                ref readonly var y = ref skip(dst,i);
                f.SrcMap[x] = (ushort)i;
            }
            return ref f;
        }

        [Op, Closures(Closure)]
        public static fx16<ushort,T> fx<T>(N16 n, MemoryAddress src, MemoryAddress dst)
            where T : unmanaged
                => new fx16<ushort,T>(src, dst);

        [Op, Closures(Closure)]
        public static ref fx16<ushort,T> fx<T>(N16 n, ReadOnlySpan<ushort> src, ReadOnlySpan<T> dst, out fx16<ushort,T> f)
            where T : unmanaged
        {
            f = fx<T>(n, address(first(src)), address(first(dst)));
            return ref fx(n,ref f, src, dst);
        }

        /// <summary>
        /// Defines a total function over a 16-bit domain
        /// </summary>
        public unsafe struct fx16<S,T> : IFunction<fx16<S,T>,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            readonly Ptr<S> PSrc;

            readonly Ptr<T> PDst;

            internal readonly Index<ushort> SrcMap;

            internal uint Size;

            internal const uint Capacity = ushort.MaxValue + 1;

            [MethodImpl(Inline)]
            internal fx16(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<S>();
                PDst = dst.Pointer<T>();
                SrcMap = alloc<ushort>(Capacity);
            }

            [MethodImpl(Inline)]
            ref readonly ushort iY(ushort x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public T Eval(S x)
                => skip(cover(PDst.P, Size), iY(u16(x)));

            [MethodImpl(Inline)]
            public kvp<S,T> Map(S x)
                => api.map(x, Eval(x));
        }
    }
}