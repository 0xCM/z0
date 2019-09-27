//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    using static zfunc;    

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vflip(in Vec128<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<byte> vflip(in Vec128<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<short> vflip(in Vec128<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<ushort> vflip(in Vec128<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<int> vflip(in Vec128<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<uint> vflip(in Vec128<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<long> vflip(in Vec128<long> src)
            => Vec128.FromParts(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec128<ulong> flip(in Vec128<ulong> src)
            => Vec128.FromParts(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vflip(in Vec256<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<byte> vflip(in Vec256<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<byte> vflip(Vector256<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<short> vflip(in Vec256<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<ushort> vflip(in Vec256<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<ushort> vflip(Vector256<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<int> vflip(in Vec256<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<uint> vflip(in Vec256<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<uint> vflip(Vector256<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<long> vflip(in Vec256<long> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<ulong> vflip(in Vec256<ulong> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vector256<ulong> vflip(Vector256<ulong> src)
            => Xor(src, CompareEqual(src,src));

    }
}