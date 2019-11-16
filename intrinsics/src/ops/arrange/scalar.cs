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
    
    using static zfunc;

    partial class dinx    
    {                
        /// <summary>
        /// __m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        /// Extracts the lower 64 bits from the source vector to create a scalar vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vmovescalar(Vector128<long> src)
            => MoveScalar(src);

        /// <summary>
        /// __m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        /// Extracts the lower 64 bits from the source vector to create a scalar vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vmovescalar(Vector128<ulong> x)
            => MoveScalar(x);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> vscalar(sbyte src)
            => v8i(vscalar((int)src));

        [MethodImpl(Inline)]
        public static Vector128<byte> vscalar(byte src)
            => v8u(vscalar((uint)src));

        [MethodImpl(Inline)]
        public static Vector128<short> vscalar(short src)
            => v16i(vscalar((int)src));

        [MethodImpl(Inline)]
        public static Vector128<ushort> vscalar(ushort src)
            => v16u(vscalar((uint)src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vscalar(int src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vscalar(uint src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vscalar(long src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vscalar(ulong src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<float> vscalar(float src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> vscalar(double src)
            => LoadScalarVector128(&src);
    }
}