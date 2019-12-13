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
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static byte clmulr(N8 r, byte a, byte b, ushort poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= (ushort)dinx.clmul((ushort)(prod >> 8), poly);
            prod ^= (ushort)dinx.clmul((ushort)(prod >> 8), poly);
            return (byte)prod;
        }

        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static ushort clmulr(N16 r, ushort a, ushort b, uint poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= (uint)dinx.clmul(prod >> 16, poly);
            prod ^= (uint)dinx.clmul(prod >> 16, poly);
            return (ushort)prod;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static uint clmulr(N32 r, uint a, uint b, ulong poly)
        {
            var prod = clmul(a,b);
            prod ^= clmul(prod >> 32, poly).lo;
            prod ^= clmul(prod >> 32, poly).lo;
            return (uint)prod;
        }

        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static UInt128 clmul(ulong lhs, ulong rhs)
        {
            var a = ginx.vscalar(n128, lhs);
            var b = ginx.vscalar(n128, rhs);
            return CarrylessMultiply(a,b,0x00);
        }

        [MethodImpl(Inline)]
        public static ulong clmul64(ulong x, ulong y)
        {
            var u = ginx.vscalar(n128, x);
            var v = ginx.vscalar(n128, y);
            var z = CarrylessMultiply(u, v, 0);
            return vcell(z,0);
        }


        /// <summary>
        /// Computes the caryless 16-bit product of two 8-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort clmul(byte lhs, byte rhs)
            => (ushort)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// Returns the caryless 32 bit product of two 16-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static uint clmul(ushort lhs, ushort rhs)
            => (uint)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// Returns the caryless 64 bit product from two 32-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong clmul(uint lhs, uint rhs)
            => clmul((ulong)lhs, (ulong)rhs).lo;

    }
}