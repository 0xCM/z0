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
        public static Vec128<byte> vor(in Vec128<byte> x, in Vec128<byte> y)
            => Or(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vor(in Vec128<short> x, in Vec128<short> y)
            => Or(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> vor(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => Or(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vor(in Vec128<ushort> x, in Vec128<ushort> y)
            => Or(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<int> vor(in Vec128<int> x, in Vec128<int> y)
            => Or(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<uint> vor(in Vec128<uint> x, in Vec128<uint> y)
            => Or(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<long> vor(in Vec128<long> x, in Vec128<long> y)
            => Or(x.xmm, y.xmm);


        [MethodImpl(Inline)]
        public static Vec128<ulong> vor(in Vec128<ulong> x, in Vec128<ulong> y)
            => Or(x.xmm, y.xmm);


        [MethodImpl(Inline)]
        public static Vec256<byte> vor(in Vec256<byte> x, in Vec256<byte> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<short> vor(in Vec256<short> x, in Vec256<short> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vor(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ushort> vor(in Vec256<ushort> x, in Vec256<ushort> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<int> vor(in Vec256<int> x, in Vec256<int> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<uint> vor(in Vec256<uint> x, in Vec256<uint> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<long> vor(in Vec256<long> x, in Vec256<long> y)
            => Or(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vor(in Vec256<ulong> x, in Vec256<ulong> y)
            => Or(x.ymm, y.ymm);

    }

}