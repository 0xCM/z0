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

    partial struct BitFlow
    {
        [Op]
        public static fx8 fx(N8 n, MemoryAddress src, MemoryAddress dst)
            => new fx8(src, dst);

        [Op, Closures(Closure)]
        public static fx8<byte,T> fx<T>(N8 n, MemoryAddress src, MemoryAddress dst)
            where T : unmanaged
                => new fx8<byte,T>(src, dst);

        public static fx8<S,T> fx<S,T>(N8 n, MemoryAddress src, MemoryAddress dst)
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
        public static ref fx8<byte,T> fx<T>(N8 n, ref fx8<byte,T> f, ReadOnlySpan<byte> src, ReadOnlySpan<T> dst)
            where T : unmanaged
        {
            f.SrcMap.Clear();
            var count = min(min(src.Length, dst.Length), BitFlow.fx8.Capacity);
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
        public static ref fx8<byte,T> fx<T>(N8 n, ReadOnlySpan<byte> src, ReadOnlySpan<T> dst, out fx8<byte,T> f)
            where T : unmanaged
        {
            f = fx<T>(n, address(first(src)), address(first(dst)));
            return ref fx(n, ref f, src, dst);
        }

        /// <summary>
        /// Defines a total function over an 8-bit domain
        /// </summary>
        public unsafe struct fx8 : IFunction<fx8,byte,byte>
        {
            readonly Ptr<byte> PSrc;

            readonly Ptr<byte> PDst;

            internal readonly Index<byte> SrcMap;

            internal uint Size;

            internal const uint Capacity = 256;

            [MethodImpl(Inline)]
            internal fx8(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<byte>();
                PDst = dst.Pointer<byte>();
                SrcMap = alloc<byte>(Capacity);
            }

            [MethodImpl(Inline)]
            ref readonly byte iY(byte x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public byte Eval(byte x)
                => skip(cover(PDst.P, Size), iY(x));

            [MethodImpl(Inline)]
            public kvp<byte,byte> Map(byte x)
                => kv(x, Eval(x));
        }

        /// <summary>
        /// Defines a total function over an 8-bit domain
        /// </summary>
        public unsafe struct fx8<S,T> : IFunction<fx8<S,T>,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            readonly Ptr<S> PSrc;

            readonly Ptr<T> PDst;

            internal readonly Index<byte> SrcMap;

            internal uint Size;

            internal const uint Capacity = 256;

            [MethodImpl(Inline)]
            internal fx8(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<S>();
                PDst = dst.Pointer<T>();
                SrcMap = alloc<byte>(Capacity);
            }

            [MethodImpl(Inline)]
            ref readonly byte iY(byte x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public T Eval(S x)
                => skip(cover(PDst.P, Size), iY(u8(x)));

            [MethodImpl(Inline)]
            public kvp<S,T> Map(S x)
                => kv(x, Eval(x));
        }
    }
}