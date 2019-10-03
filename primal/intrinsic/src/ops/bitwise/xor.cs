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
    
    using static As;
    using static zfunc;

    partial class dinx
    {         
        [MethodImpl(Inline)]
        public static Vec128<byte> vxor(in Vec128<byte> x, in Vec128<byte> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vxor(in Vec128<short> x, in Vec128<short> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> vxor(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vxor(in Vec128<ushort> x, in Vec128<ushort> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<int> vxor(in Vec128<int> x, in Vec128<int> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<uint> vxor(in Vec128<uint> x, in Vec128<uint> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<long> vxor(in Vec128<long> x, in Vec128<long> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vxor(in Vec128<ulong> x, in Vec128<ulong> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec128<float> vxor(in Vec128<float> x, in Vec128<float> y)
            => Xor(x.xmm, y.xmm);
        
        [MethodImpl(Inline)]
        public static Vec128<double> vxor(in Vec128<double> x, in Vec128<double> y)
            => Xor(x.xmm, y.xmm);

        [MethodImpl(Inline)]
        public static Vec256<byte> vxor(in Vec256<byte> x, in Vec256<byte> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<short> vxor(in Vec256<short> x, in Vec256<short> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxor(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ushort> vxor(in Vec256<ushort> x, in Vec256<ushort> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<int> vxor(in Vec256<int> x, in Vec256<int> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<uint> vxor(in Vec256<uint> x, in Vec256<uint> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// __m256i _mm256_xor_si256 (__m256i a, __m256i b)VPXOR ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vec256<long> vxor(in Vec256<long> x, in Vec256<long> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vxor(in Vec256<ulong> x, in Vec256<ulong> y)
            => Xor(x.ymm, y.ymm);

        [MethodImpl(Inline)]
        public static Vec256<float> vxor(in Vec256<float> x, in Vec256<float> y)
            => Xor(x.ymm, y.ymm);
        
        [MethodImpl(Inline)]
        public static Vec256<double> vxor(in Vec256<double> x, in Vec256<double> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the combined XOR of three operands
        /// </summary>
        /// <param name="x0">The first vector</param>
        /// <param name="x1">The second vector</param>
        /// <param name="x2">The third vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> xor(in Vec128<sbyte> x0, in Vec128<sbyte> x1, in Vec128<sbyte> x2)
            => Xor(Xor(x0, x1),x2);

        /// <summary>
        /// Computes the combined XOR of three operands
        /// </summary>
        /// <param name="x0">The first vector</param>
        /// <param name="x1">The second vector</param>
        /// <param name="x2">The third vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vxor(in Vec128<byte> x0, in Vec128<byte> x1, in Vec128<byte> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vxor(in Vec128<short> x0, in Vec128<short> x1,  in Vec128<short> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vxor(in Vec128<ushort> x0, in Vec128<ushort> x1, in Vec128<ushort> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<int> vxor(in Vec128<int> x0, in Vec128<int> x1, in Vec128<int> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<uint> vxor(in Vec128<uint> x0, in Vec128<uint> x1, in Vec128<uint> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<long> vxor(in Vec128<long> x0, in Vec128<long> x1, in Vec128<long> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vxor(in Vec128<ulong> x0, in Vec128<ulong> x1, in Vec128<ulong> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(in Vec128<float> x0, in Vec128<float> x1, in Vec128<float> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);
        
        [MethodImpl(Inline)]
        public static Vec128<double> vxor(in Vec128<double> x0, in Vec128<double> x1, in Vec128<double> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec256<byte> vxor(in Vec256<byte> x0, in Vec256<byte> x1, in Vec256<byte> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<short> vxor(in Vec256<short> x0, in Vec256<short> x1, in Vec256<short> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxor(in Vec256<sbyte> x0, in Vec256<sbyte> x1, in Vec256<sbyte> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(in Vec256<ushort> x0, in Vec256<ushort> x1, in Vec256<ushort> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<int> vxor(in Vec256<int> x0, in Vec256<int> x1, in Vec256<int> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<uint> vxor(in Vec256<uint> x0, in Vec256<uint> x1, in Vec256<uint> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<long> vxor(in Vec256<long> x0, in Vec256<long> x1, in Vec256<long> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vxor(in Vec256<ulong> x0, in Vec256<ulong> x1, in Vec256<ulong> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<float> vxor(in Vec256<float> x0, in Vec256<float> x1, in Vec256<float> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);
        
        [MethodImpl(Inline)]
        public static Vec256<double> vxor(in Vec256<double> x0, in Vec256<double> x1, in Vec256<double> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);
 
   }

}