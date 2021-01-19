//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
    using static Part;

    partial struct BitLogic
    {
        [ApiHost(ApiNames.BitLogicU8, true)]
        public readonly struct U8
        {
            /// <summary>
            /// Returns the left operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Left]
            public static byte left(byte a, byte b)
                => a;

            /// <summary>
            /// Returns the right operand value
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Right]
            public static byte right(byte a, byte b)
                => b;

            /// <summary>
            /// Returns 0, irrespective of the operand values
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), False]
            public static byte @false(byte a, byte b)
                => 0;

            /// <summary>
            /// Computes the bitwise not c := ~src of the source operand
            /// </summary>
            /// <param name="src">The source operand</param>
            [MethodImpl(Inline), Not]
            public static byte not(byte src)
                => (byte)(~ src);

            /// <summary>
            /// Computes the bitwise and c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), And]
            public static byte and(byte a, byte b)
                => (byte)(a & b);

            /// <summary>
            /// Computes the bitwise or c := a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Or]
            public static byte or(byte a, byte b)
                => (byte)(a | b);

            /// <summary>
            /// Computes the converse implication c := ~a | b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), CImpl]
            public static byte cimpl(byte a, byte b)
                => (byte)(~a | b);

            /// <summary>
            /// Computes the converse nonimplication c := a & ~b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), CNonImpl]
            public static byte cnonimpl(byte a, byte b)
                => (byte)AndNot((uint)b,(uint)a);

            /// <summary>
            /// Computes the material implication c := a | ~b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Impl]
            public static byte impl(byte a, byte b)
                => (byte)(a | ~b);

            /// <summary>
            /// Computes the bitwise nand c := ~(a & b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            /// <typeparam name="T">The primal operand type</typeparam>
            [MethodImpl(Inline), Nand]
            public static byte nand(byte a, byte b)
                => not(and(a,b));

            /// <summary>
            /// Computes the material nonimplication z := ~a & b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), NonImpl]
            public static byte nonimpl(byte a, byte b)
                => (byte)AndNot((uint)a,(uint)b);

            /// <summary>
            /// Computes the bitwise nor c := ~(a | b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Nor]
            public static byte nor(byte a, byte b)
                => not(or(a,b));

            /// <summary>
            /// Computes the bitwise xor c := a ^ b for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xor]
            public static byte xor(byte a, byte b)
                => (byte)(a ^ b);

            /// <summary>
            /// Computes the bitwise xnor c := ~(a ^ b) for operands a and b
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), Xnor]
            public static byte xnor(byte a, byte b)
                => not(xor(a,b));

            /// <summary>
            /// Computes the bitwise not of the left operand
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), LNot]
            public static byte lnot(byte a, byte b)
                => not(a);

            /// <summary>
            /// Computes the bitwise not of the right operand
            /// </summary>
            /// <param name="a">The left operand</param>
            /// <param name="b">The right operand</param>
            [MethodImpl(Inline), RNot]
            public static byte rnot(byte a, byte b)
                => not(b);

            /// <summary>
            /// Computes the bitwise select of the operands
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            /// <param name="c">The third operand</param>
            [MethodImpl(Inline), Select]
            public static byte select(byte a, byte b, byte c)
                => or(and(a,b), nonimpl(a,c));
        }
    }
}