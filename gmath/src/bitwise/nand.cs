//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static byte nand(byte a, byte b)
            => (byte)(nand((uint)a,(uint)b));

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static ushort nand(ushort a, ushort b)
            => (ushort)(nand((uint)a,(uint)b));

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static uint nand(uint a, uint b)
            => ~ (a & b);

        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static ulong nand(ulong a, ulong b)
            => ~ (a & b);
    }
}