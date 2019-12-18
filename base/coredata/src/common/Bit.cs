//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public readonly struct bit
    {
        readonly uint state;

        const uint _off = 0;

        const uint _on = 1;

        public const char Zero = '0';

        public const char One = '1';

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
        
        [MethodImpl(Inline)]
        public unsafe static bit From(bool src)        
        {
            uint state = *((byte*)(&src));
            return new bit(state);
        }

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(sbyte src, int pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(byte src, int pos)
            => Wrap(((uint)src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(short src, int pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(ushort src, int pos)
            => Wrap(((uint)src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(int src, int pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(long src, int pos)
            => new bit((src & (1L << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(uint src, int pos)
            => Wrap((src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bit test(ulong src, int pos)
            => Wrap((uint)((src >> pos) & 1));

        /// <summary>
        /// The identity function
        /// </summary>
        /// <param name="b">The source bit</param>
        [MethodImpl(Inline)]
        public static bit identity(bit b)
            => b;

        /// <summary>
        /// Computes c = a & b
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit and(bit a, bit b) 
            => Wrap(a.state & b.state);

        /// <summary>
        /// Computes c = a | b
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit or(bit a, bit b) 
            => Wrap(a.state | b.state);

        /// <summary>
        /// Computes c = a ^ b
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit xor(bit a, bit b)
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Computes c := ~a = !a
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit not(bit a)
            => SafeWrap(~a.state);

        /// <summary>
        /// Computes c := ~ (a & b)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit nand(bit a, bit b)
            => SafeWrap(~(a.state & b.state));

        /// <summary>
        /// Computes c := ~ (a | b)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline)]
        public static bit nor(bit a, bit b)
            => SafeWrap(~(a.state | b.state));

        /// <summary>
        /// Computes c := ~ (a ^ b)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline)]
        public static bit xnor(bit a, bit b)
            => SafeWrap(~(a.state ^ b.state));

        /// <summary>
        /// Computes c := a -> b := a | ~b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Material_conditional</remarks>
        [MethodImpl(Inline)]
        public static bit impl(bit a, bit b)
            => or(a,  not(b));

        /// <summary>
        /// Computes the nonimplication c := a < -- b := ~(a | ~b) = ~a & b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit nonimpl(bit a, bit b)
            => and(not(a),  b);

        /// <summary>
        /// Computes the converse implication c := ~a | b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit cimpl(bit a, bit b)
            => or(not(a),  b);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit cnonimpl(bit a, bit b)
            => and(a, not(b));

        /// <summary>
        /// Computes the ternary select s := a ? b : c = (a & b) | (~a & c)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static bit select(bit a, bit b, bit c)
            => SafeWrap((a.state & b.state) | (~a.state & c.state));

        [MethodImpl(Inline)]
        public static bit Parse(char c)
            => c == '1';

        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline)]
        public static bool operator true(bit b)
            => b.state != 0;

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
            => src.state != 0;

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator byte(bit src)
            => (byte)src.state;

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator sbyte(bit src)
            => (sbyte)src.state;

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
            => (ushort)src.state;

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator short(bit src)
            => (short)src.state;

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
        /// Defines an explicit bit -> long conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator long(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit bit -> int conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator int(bit src)
            => (int)src.state;

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
        unsafe bit(bool on)
            => this.state  = *((byte*)(&on));

        [MethodImpl(Inline)]
        bit(uint state)
            => this.state = state;


        [MethodImpl(Inline)]
        public bool Equals(bit b)
            => state == b.state;
        
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