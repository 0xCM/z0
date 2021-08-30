//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    partial struct Blit
    {
        partial struct Factory
        {
            [Op]
            public static fx8 fx8(MemoryAddress src, MemoryAddress dst)
                => new fx8(src, dst);

            [Op, Closures(Closure)]
            public static fx8<byte,T> fx8<T>(MemoryAddress src, MemoryAddress dst)
                where T : unmanaged
                    => new fx8<byte,T>(src, dst);

            [Op, Closures(Closure)]
            public static fx16<ushort,T> fx16<T>(MemoryAddress src, MemoryAddress dst)
                where T : unmanaged
                    => new fx16<ushort,T>(src, dst);

            public static fx8<S,T> fx8<S,T>(MemoryAddress src, MemoryAddress dst)
                where T : unmanaged
                where S : unmanaged
                    => new fx8<S,T>(src, dst);

            /// <summary>
            /// Defines a function fx8:u8->T
            /// </summary>
            /// <param name="f">The function under specification</param>
            /// <param name="src">The source domain points</param>
            /// <param name="dst">The target domain points</param>
            /// <typeparam name="T">The target domain</typeparam>
            [Op, Closures(Closure)]
            public static ref fx8<byte,T> fx8<T>(ref fx8<byte,T> f, ReadOnlySpan<byte> src, ReadOnlySpan<T> dst)
                where T : unmanaged
            {
                f.SrcMap.Clear();
                var count = min(min(src.Length, dst.Length), Blit.fx8.Capacity);
                f.Size = (uint)count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var x = ref skip(src,i);
                    ref readonly var y = ref skip(dst,i);
                    f.SrcMap[x] = (byte)i;
                }
                return ref f;
            }

            [Op, Closures(Closure)]
            public static ref fx8<byte,T> fx8<T>(ReadOnlySpan<byte> src, ReadOnlySpan<T> dst, out fx8<byte,T> f)
                where T : unmanaged
            {
                f = fx8<T>(address(first(src)), address(first(dst)));
                return ref fx8(ref f, src, dst);
            }

            /// <summary>
            /// Defines a function fx8:u8->T
            /// </summary>
            /// <param name="f">The function under specification</param>
            /// <param name="src">The source domain points</param>
            /// <param name="dst">The target domain points</param>
            /// <typeparam name="T">The target domain</typeparam>
            [Op, Closures(Closure)]
            public static ref fx16<ushort,T> fx16<T>(ref fx16<ushort,T> f, ReadOnlySpan<ushort> src, ReadOnlySpan<T> dst)
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
            public static ref fx16<ushort,T> fx16<T>(ReadOnlySpan<ushort> src, ReadOnlySpan<T> dst, out fx16<ushort,T> f)
                where T : unmanaged
            {
                f = fx16<T>(address(first(src)), address(first(dst)));
                return ref fx16(ref f, src, dst);
            }
        }
    }
}