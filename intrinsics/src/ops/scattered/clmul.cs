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
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
 
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vclmul(Vector128<ulong> a, Vector128<ulong> b)
            => CarrylessMultiply(a,b,0x00);

        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="mask">Specifies the components of the source vectors to multiply</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vclmul(Vector128<ulong> lhs, Vector128<ulong> rhs, ClMulMask mask)
            =>  CarrylessMultiply(lhs, rhs, (byte)mask);

        /// <summary>
        /// Computes the carryless product of two 64-bit operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vclmulr(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> poly)
        {
            var prod = vclmul(a,b);
            prod = vxor(prod, vclmul(vsrl(prod, 64), poly, ClMulMask.X00));
            prod = vxor(prod, vclmul(vsrl(prod, 64), poly, ClMulMask.X00));
            return prod;
        }
    }

    /// <summary>
    /// Defines a mask that specifies the left/right vector components from which a carry-less product will be formed
    /// </summary>
    public enum ClMulMask : byte
    {
        /// <summary>
        /// For a product P = XY, multiply the lo(X) and lo(Y)
        /// </summary>
        X00 = 0x00,

        /// <summary>
        /// For a product P = XY, multiply the lo(X) and hi(Y)
        /// </summary>
        X01 = 0x01,

        /// <summary>
        /// For a product P = XY, multiply the hi(X) and lo(Y)
        /// </summary>
        X10 = 0x10,

        /// <summary>
        /// For a product P = XY, multiply the hi(X) and hi(Y)
        /// </summary>
        X11 = 0x11,
    }    
}