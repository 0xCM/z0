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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;

    public static partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> vadd(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> vadd(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs) 
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vadd(in Vec128<short> lhs, in Vec128<short> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vadd(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<int> vadd(in Vec128<int> lhs, in Vec128<int> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<uint> vadd(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<long> vadd(in Vec128<long> lhs, in Vec128<long> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vadd(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec256<byte> vadd(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vadd(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<short> vadd(in Vec256<short> lhs, in Vec256<short> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ushort> vadd(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<int> vadd(in Vec256<int> lhs, in Vec256<int> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<uint> vadd(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<long> vadd(in Vec256<long> lhs, in Vec256<long> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vadd(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Add(lhs.ymm, rhs.ymm);

   }
}