//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static Part;

    partial struct z
    {
        /// <summary>
        /// Computes the caryless 16-bit product of two 8-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), ClMul]
        public static ushort clmul(byte lhs, byte rhs)
            => (ushort)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// Returns the caryless 32 bit product of two 16-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), ClMul]
        public static uint clmul(ushort lhs, ushort rhs)
            => (uint)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// Returns the caryless 64 bit product from two 32-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), ClMul]
        public static ulong clmul(uint lhs, uint rhs)
            => clmul((ulong)lhs, (ulong)rhs).Left;

        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), ClMul]
        public static ConstPair<ulong> clmul(ulong lhs, ulong rhs)
        {
            var a = cpu.vscalar(w128, lhs);
            var b = cpu.vscalar(w128, rhs);
            var result = CarrylessMultiply(a,b,0x00);
            return (vcell(result,0), vcell(result,1));
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline), ClMul]
        public static byte clmulr(N8 r, byte a, byte b, ushort poly)
        {
            var prod = clmul(a,b);
            prod ^= (ushort)clmul((ushort)(prod >> 8), poly);
            prod ^= (ushort)clmul((ushort)(prod >> 8), poly);
            return (byte)prod;
        }

        [MethodImpl(Inline), ClMul]
        public static ulong clmulr(N8 r, ulong a, ulong b, ulong poly)
        {
            var product = clmul64(a,b);
            product ^= clmul64(product >> 8, poly);
            product ^= clmul64(product >> 8, poly);
            return product;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline), ClMul]
        public static ushort clmulr(N16 r, ushort a, ushort b, uint poly)
        {
            var prod = clmul(a,b);
            prod ^= (uint)clmul(prod >> 16, poly);
            prod ^= (uint)clmul(prod >> 16, poly);
            return (ushort)prod;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline), ClMul]
        public static uint clmulr(N32 r, uint a, uint b, ulong poly)
        {
            var prod = clmul(a,b);
            prod ^= clmul(prod >> 32, poly).Left;
            prod ^= clmul(prod >> 32, poly).Left;
            return (uint)prod;
        }


        [MethodImpl(Inline), ClMul]
        public static ulong clmul64(ulong x, ulong y)
        {
            var u = cpu.vscalar(w128, x);
            var v = cpu.vscalar(w128, y);
            var z = CarrylessMultiply(u, v, 0);
            return vcell(z,0);
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