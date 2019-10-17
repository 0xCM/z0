//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;

    using static zfunc;

    public readonly struct bit
    {
        readonly uint state;

        /// <summary>
        /// Constructs a disabled bit
        /// </summary>
        public static bit Off => false;

        /// <summary>
        /// Constructs an enabled bit
        /// </summary>
        public static bit On => true;

        public static bit[] B01 => new bit[]{Off,On};
        
        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        public static bool operator true(bit b)
            => b.state == 1;

        /// <summary>
        /// Returns false if the bit is disabled, true otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        public static bool operator false(bit b)
            => b.state == 0;

        /// <summary>
        /// Implicitly constructs a bit from a bool
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline)]
        public static implicit operator bit(bool state)
            => new bit(state);

        /// <summary>
        /// Implicitly constructs a bool from a bit
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline)]
        public static implicit operator bool(bit src)
            => src.state == 1;

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator byte(bit src)
            => (byte)src.state;

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator ushort(bit src)
            => (ushort)src.state;

        /// <summary>
        /// Defines an explicit bit -> uint conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator uint(bit src)
            => src.state;

        /// <summary>
        /// Combines the states of the source bits
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator + (bit a, bit b) 
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator & (bit a, bit b) 
            => and(a,b);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator | (bit a, bit b) 
            => or(a,b);
            
        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator ^ (bit a, bit b) 
            => xor(a,b);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ~ (bit a) 
            => not(a);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ! (bit a) 
            => not(a);

        [MethodImpl(Inline)]
        public static bool operator ==(bit a, bit b)
            => a.state == b.state;

        [MethodImpl(Inline)]
        public static bool operator !=(bit a, bit b)
            => a.state != b.state;

        [MethodImpl(Inline)]
        bit(bool on)
            => this.state  = on ? 1u : 0u;

        [MethodImpl(Inline)]
        bit(uint state)
            => this.state = state;

        /// <summary>
        /// The identity function
        /// </summary>
        /// <param name="b">The source bit</param>
        [MethodImpl(Inline)]
        public static bit identity(bit b)
            => b;

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit and(bit a, bit b) 
            => Wrap(a.state & b.state);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit or(bit a, bit b) 
            => Wrap(a.state | b.state);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit xor(bit a, bit b)
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit not(bit a)
            => SafeWrap(~a.state);

        /// <summary>
        /// Evaluates the logical NAND of two bits, which is true iff one or both bits are off
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit nand(bit a, bit b)
            => SafeWrap(~(a.state & b.state));

        /// <summary>
        /// Evaluates the logical XNOR of two bits, also known as the logical biconditional and which 
        /// in practice is equivalent to value-based equality
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline)]
        public static bit nor(bit a, bit b)
            => SafeWrap(~(a.state | b.state));

        /// <summary>
        /// Evaluates the logical XNOR of two bits, also known as the logical biconditional and which 
        /// in practice is equivalent to value-based equality
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline)]
        public static bit xnor(bit a, bit b)
            => SafeWrap(~(a.state ^ b.state));

        /// <summary>
        /// Computes a & ~b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>    
        [MethodImpl(Inline)]
        public static bit andnot(bit a, bit b)
            => SafeWrap(a.state & ~b.state);

        /// <summary>
        /// Evaluates the implication a -> b that means if p is true then b is true
        /// </summary>
        /// <param name="antecedent">The first operand</param>
        /// <param name="consequent">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Material_conditional</remarks>
        [MethodImpl(Inline)]
        public static bit implies(bit antecedent, bit consequent)
            => !(antecedent == On && consequent == Off);

        /// <summary>
        /// Evaluates the ternary select where the second operand is returned if the first 
        /// operand is true and otherwise the third operand is returned: a ? b : c
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit select(bit a, bit b, bit c)
            => a ? b : c;

        [MethodImpl(Inline)]
        public static bit xor1(bit a)
            => !(a ^ On);

        [MethodImpl(Inline)]
        static bit Wrap(uint state)
            => new bit(state);

        [MethodImpl(Inline)]
        static bit SafeWrap(uint state)
            => new bit(state & 1);


        [MethodImpl(Inline)]
        public bool Equals(bit b)
            => state == b.state;

        public override bool Equals(object b)
            => b is bit x && Equals(x);

        public override int GetHashCode()
            => state.GetHashCode();
  
    }


}