//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct BitLogic
    {
        [ApiHost(ApiNames.BitLogicBits, true)]
        public struct Bits
        {
            /// <summary>
            /// Computes c = a & b
            /// </summary>
            /// <param name="a">The left bit</param>
            /// <param name="b">The right bit</param>
            [MethodImpl(Inline), Op]
            public static bit and(bit a, bit b)
                => new bit(a.State & b.State);

            /// <summary>
            /// Computes c = a | b
            /// </summary>
            /// <param name="a">The left bit</param>
            /// <param name="b">The right bit</param>
            [MethodImpl(Inline), Op]
            public static bit or(bit a, bit b)
                => new bit(a.State | b.State);

            /// <summary>
            /// Computes c = a ^ b
            /// </summary>
            /// <param name="a">The left bit</param>
            /// <param name="b">The right bit</param>
            [MethodImpl(Inline), Op]
            public static bit xor(bit a, bit b)
                => new bit(a.State ^ b.State);

            /// <summary>
            /// Computes c := ~a = !a
            /// </summary>
            /// <param name="a">The source bit</param>
            [MethodImpl(Inline), Op]
            public static bit not(bit a)
                => new bit(!a.State);

            /// <summary>
            /// Computes c := ~ (a & b)
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            [MethodImpl(Inline), Op]
            public static bit nand(bit a, bit b)
                => new bit(!(a.State & b.State));

            /// <summary>
            /// Computes c := ~ (a | b)
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
            [MethodImpl(Inline), Op]
            public static bit nor(bit a, bit b)
                => new bit(!(a.State | b.State));

            /// <summary>
            /// Computes c := ~ (a ^ b)
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
            [MethodImpl(Inline), Op]
            public static bit xnor(bit a, bit b)
                => new bit(!(a.State ^ b.State));

            /// <summary>
            /// Computes c := a -> b := a | ~b
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            /// <remarks>See https://en.wikipedia.org/wiki/Material_conditional</remarks>
            [MethodImpl(Inline), Op]
            public static bit impl(bit a, bit b)
                => or(a, not(b));

            /// <summary>
            /// Computes the nonimplication c := a < -- b := ~(a | ~b) = ~a & b
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            [MethodImpl(Inline), Op]
            public static bit nonimpl(bit a, bit b)
                => and(not(a),  b);

            /// <summary>
            /// Computes the converse implication c := ~a | b
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            [MethodImpl(Inline), Op]
            public static bit cimpl(bit a, bit b)
                => or(not(a),  b);

            /// <summary>
            /// Computes the converse nonimplication c := a & ~b
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            [MethodImpl(Inline), Op]
            public static bit cnonimpl(bit a, bit b)
                => and(a, not(b));

            /// <summary>
            /// Computes the ternary select s := a ? b : c = (a & b) | (~a & c)
            /// </summary>
            /// <param name="a">The first operand</param>
            /// <param name="b">The second operand</param>
            [MethodImpl(Inline), Select]
            public static bit select(bit a, bit b, bit c)
                => new bit((a.State & b.State) | (!a.State & c.State));
        }
    }
}