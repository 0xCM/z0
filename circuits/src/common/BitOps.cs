//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.IO.Pipes;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class BitOps
    {
        /// <summary>
        /// Computes the logical AND of two bits
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static Bit and(Bit a, Bit b)
            => a & b;

        /// <summary>
        /// Computes the logical OR of two bits
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static Bit or(Bit a, Bit b)
            => a | b;

        /// <summary>
        /// Computes the logical XOR of two bits
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static Bit xor(Bit a, Bit b)
            => a ^ b;

        /// <summary>
        /// Computes the logical not of a bit
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static Bit not(Bit a)
            => !a;

        /// <summary>
        /// Evaluates the logical NOR of two bits
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_NOR</remarks>
        [MethodImpl(Inline)]
        public static Bit nor(Bit a, Bit b)
            => not(or(a,b));

        /// <summary>
        /// Evaluates the logical XNOR of two bits, also known as the logical biconditional and which 
        /// in practice is equivalent to value-based equality
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline)]
        public static Bit xnor(Bit a, Bit b)
            => not(xor(a,b));

        /// <summary>
        /// Evaluates the logical NAND of two bits, which is true iff one or both bits are off
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static Bit nand(Bit a, Bit b)
            => a == Bit.Off || b == Bit.Off;

        /// <summary>
        /// Evaluates the implication a -> b that means if p is true then b is true
        /// </summary>
        /// <param name="antecedent">The first operand</param>
        /// <param name="consequent">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Material_conditional</remarks>
        [MethodImpl(Inline)]
        public static Bit implies(Bit antecedent, Bit consequent)
            => not(antecedent == Bit.On && consequent == Bit.Off);

        /// <summary>
        /// Evaluates the ternary select where the second operand is returned if the first 
        /// operand is true and otherwise the third operand is returned: a ? b : c
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static Bit select(Bit a, Bit b, Bit c)
            => a ? b : c;
    }

}