//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static Seed;

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_andnot_ps (__m128 a, __m128 b) ANDNPS xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vandnot(Vector128<float> x, Vector128<float> y)
            => AndNot(y, x);

        /// <summary>
        /// _mm_andnot_pd:
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vandnot(Vector128<double> x, Vector128<double> y)
            => AndNot(y, x);        

       /// <summary>
        /// __m256 _mm256_andnot_ps (__m256 a, __m256 b) VANDNPS ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vandnot(Vector256<float> x, Vector256<float> y)
            => AndNot(y, x);

        /// <summary>
        /// __m256d _mm256_andnot_pd (__m256d a, __m256d b) VANDNPD ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vandnot(Vector256<double> x, Vector256<double> y)
            => AndNot(y, x);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vxor1(Vector128<float> x)
            => Xor(x, CompareEqual(default(Vector128<float>), default(Vector128<float>)));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vxor1(Vector128<double> x)
            => Xor(x, CompareEqual(default(Vector128<double>), default(Vector128<double>)));


        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vxor1(Vector256<float> x)
            => Xor(x, Compare(default(Vector256<float>), default(Vector256<float>), FloatComparisonMode.OrderedEqualNonSignaling));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vxor1(Vector256<double> x)
            => Xor(x, Compare(default(Vector256<double>), default(Vector256<double>), FloatComparisonMode.OrderedEqualNonSignaling));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vxnor(Vector128<float> x, Vector128<float> y)
            => dinxfp.vnot(Xor(x, y));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vxnor(Vector128<double> x, Vector128<double> y)
            => dinxfp.vnot(Xor(x, y));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vxnor(Vector256<float> x, Vector256<float> y)
            => dinxfp.vnot(Xor(x, y));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vxnor(Vector256<double> x, Vector256<double> y)
            => dinxfp.vnot(Xor(x, y));

        [MethodImpl(Inline), Op]
        public static Vector128<float> vnot(Vector128<float> src)
            => Xor(src, CompareEqual(src, src));

        [MethodImpl(Inline), Op]
        public static Vector128<double> vnot(Vector128<double> src)
            => Xor(src, CompareEqual(src, src));

        [MethodImpl(Inline), Op]
        public static Vector256<float> vnot(Vector256<float> src)
            => Xor(src, Compare(src, src, FloatComparisonMode.OrderedEqualNonSignaling));

        [MethodImpl(Inline), Op]
        public static Vector256<double> vnot(Vector256<double> src)
            => Xor(src, Compare(src, src, FloatComparisonMode.OrderedEqualNonSignaling));

        /// <summary>
        /// __m128 _mm_xor_ps (__m128 a, __m128 b) XORPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vxor(Vector128<float> lhs, Vector128<float> rhs)
            => Xor(lhs, rhs);
        
        /// <summary>
        /// __m128d _mm_xor_pd (__m128d a, __m128d b) XORPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vxor(Vector128<double> lhs, Vector128<double> rhs)
            => Xor(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_xor_ps (__m256 a, __m256 b) VXORPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vxor(Vector256<float> lhs, Vector256<float> rhs)
            => Xor(lhs, rhs);
        
        /// <summary>
        ///  __m256 _mm256_xor_ps (__m256 a, __m256 b) VXORPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vxor(Vector256<double> lhs, Vector256<double> rhs)
            => Xor(lhs, rhs);
    
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vxor(in Vector128<float> x, in Vector128<float> y)
            => Xor(x, y);
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vxor(in Vector128<double> x, in Vector128<double> y)
            => Xor(x, y);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vxor(in Vector256<float> x, in Vector256<float> y)
            => Xor(x, y);
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vxor(in Vector256<double> x, in Vector256<double> y)
            => Xor(x, y);

          [MethodImpl(Inline), Op]
        public static Vector128<float> vor(Vector128<float> x, Vector128<float> y)
            => Or(x, y);
        
        [MethodImpl(Inline), Op]
        public static Vector128<double> vor(Vector128<double> x, Vector128<double> y)
            => Or(x, y);

        [MethodImpl(Inline), Op]
        public static Vector256<float> vor(Vector256<float> x, Vector256<float> y)
            => Or(x, y);
        
        [MethodImpl(Inline), Op]
        public static Vector256<double> vor(Vector256<double> x, Vector256<double> y)
            => Or(x, y);
          
    }

}