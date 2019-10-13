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

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vnot(in Vec128<sbyte> src)
            => Xor(src.xmm, CompareEqual(src.xmm, src.xmm));

        [MethodImpl(Inline)]
        public static Vec128<byte> vnot(in Vec128<byte> src)
            => Xor(src.xmm, CompareEqual(src.xmm, src.xmm));

        [MethodImpl(Inline)]
        public static Vec128<short> vnot(in Vec128<short> src)
            => Xor(src.xmm, CompareEqual(src.xmm, src.xmm));

        [MethodImpl(Inline)]
        public static Vec128<ushort> vnot(in Vec128<ushort> src)
            => Xor(src.xmm, CompareEqual(src.xmm, src.xmm));

        [MethodImpl(Inline)]
        public static Vec128<int> vnot(in Vec128<int> src)
            => Xor(src.xmm, CompareEqual(src.xmm, src.xmm));

        [MethodImpl(Inline)]
        public static Vec128<uint> vnot(in Vec128<uint> src)
            => Xor(src.xmm, CompareEqual(src.xmm, src.xmm));

        [MethodImpl(Inline)]
        public static Vec128<long> vnot(in Vec128<long> src)
            => vnot(src.As<uint>()).As<long>(); //Vec128.FromParts(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vnot(in Vec128<ulong> src)
            => vnot(src.As<uint>()).As<ulong>();  //Vec128.FromParts(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vnot(in Vec256<sbyte> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<byte> vnot(in Vec256<byte> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<short> vnot(in Vec256<short> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<ushort> vnot(in Vec256<ushort> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<int> vnot(in Vec256<int> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<uint> vnot(in Vec256<uint> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<long> vnot(in Vec256<long> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));

        [MethodImpl(Inline)]
        public static Vec256<ulong> vnot(in Vec256<ulong> src)
            => Xor(src.ymm, CompareEqual(src.ymm, src.ymm));
    }
}