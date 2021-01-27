//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;

    using static Part;
    using static z;

    partial struct z
    {
       /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), ClMul]
        public static Vector128<ulong> vclmul(Vector128<ulong> a, Vector128<ulong> b)
            => CarrylessMultiply(a,b,0x00);

        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="mask">Specifies the components of the source vectors to multiply</param>
        [MethodImpl(Inline), ClMul]
        public static Vector128<ulong> vclmul(Vector128<ulong> lhs, Vector128<ulong> rhs, ClMulMask mask)
            =>  CarrylessMultiply(lhs, rhs, (byte)mask);

        /// <summary>
        /// Computes the carryless product of two 64-bit operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline), ClMul]
        public static Vector128<ulong> vclmulr(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> poly)
        {
            var prod = vclmul(a,b);
            prod = cpu.vxor(prod, vclmul(vsrl(prod, 64), poly, ClMulMask.X00));
            prod = cpu.vxor(prod, vclmul(vsrl(prod, 64), poly, ClMulMask.X00));
            return prod;
        }
    }
}