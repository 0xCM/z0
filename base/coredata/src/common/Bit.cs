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

        const uint _off = 0;

        const uint _on = 1;

        /// <summary>
        /// Constructs a disabled bit
        /// </summary>
        public static bit Off 
        {
             [MethodImpl(Inline)]
             get  => new bit(_off);
        }

        /// <summary>
        /// Constructs an enabled bit
        /// </summary>
        public static bit On 
        {
             [MethodImpl(Inline)]
             get  => new bit(_on);
        }

        public static bit[] B01 
        {
            [MethodImpl(Inline)]
            get => new bit[]{Off,On};
        }
        
        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline)]
        public static bool operator true(bit b)
            => b.state == 1;

        /// <summary>
        /// Returns false if the bit is disabled, true otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline)]
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
            => src.AsUInt8();

        /// <summary>
        /// Defines an explicit byte -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator bit(byte src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator ushort(bit src)
            => src.AsUInt16();

        /// <summary>
        /// Defines an explicit ushort -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator bit(ushort src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> uint conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator uint(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit uint -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator bit(uint src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> ulong conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator ulong(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit ulong -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator bit(ulong src)
            => SafeWrap(src);

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
        /// Computes and(a,not(b))
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit andnot(bit a, bit b)
            => SafeWrap(a.state & ~b.state);

        /// <summary>
        /// Evaluates the implication a -> b := a | ~b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Material_conditional</remarks>
        [MethodImpl(Inline)]
        public static bit imply(bit a, bit b)
            => or(a,  not(b));

        /// <summary>
        /// Evaluates the nonimplication a <- b := ~(a | ~b) = ~a & b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit notimply(bit a, bit b)
            => and(not(a),  b);

        [MethodImpl(Inline)]
        public static bit cimply(bit a, bit b)
            => or(not(a),  b);

        [MethodImpl(Inline)]
        public static bit cnotimply(bit a, bit b)
            => and(a, not(b));

        /// <summary>
        /// Evaluates the ternary select where the second operand is returned if the first 
        /// operand is true and otherwise the third operand is returned: a ? b : c
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit select(bit a, bit b, bit c)
            => SafeWrap((a.state & b.state) | (~a.state & c.state));

        /// <summary>
        /// Computes xor(a,1)
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static bit xor1(bit a)
            => !(a ^ On);


        [MethodImpl(Inline)]
        public bool Equals(bit b)
            => state == b.state;
        
        /// <summary>
        /// Presents the bit state as an 8-bit unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public byte AsUInt8()
            => (byte)state;            

        /// <summary>
        /// Presents the bit state as a 16-bit unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public ushort AsUInt16()
            => (ushort)state;

        /// <summary>
        /// Presents the bit state as a 32-bit unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public uint AsUInt32()
            => state;

        /// <summary>
        /// Presents the bit state as a 64-bit unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public ulong AsUInt64()
            => state;

        public override bool Equals(object b)
            => b is bit x && Equals(x);

        public override int GetHashCode()
            => state.GetHashCode();
  
        public string Format()
            => state.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        static bit Wrap(uint state)
            => new bit(state);

        [MethodImpl(Inline)]
        static bit SafeWrap(byte state)
            => new bit((uint)state & 1);

        [MethodImpl(Inline)]
        static bit SafeWrap(ushort state)
            => new bit((uint)state & 1);

        [MethodImpl(Inline)]
        static bit SafeWrap(uint state)
            => new bit(state & 1);

        [MethodImpl(Inline)]
        static bit SafeWrap(ulong state)
            => new bit((uint)state & 1);

    }
}