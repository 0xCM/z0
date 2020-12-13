//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiType, Datatype]
    public readonly struct bit : ITextual, IEquatable<bit>
    {
        internal readonly bool State;

        public const char Zero = '0';

        public const char One = '1';

        public static bit[] B01
        {
            [MethodImpl(Inline)]
            get => new bit[]{Off,On};
        }

        [MethodImpl(Inline)]
        public static bit Parse(char c)
            => c == One;

        [MethodImpl(Inline)]
        public bit(bool state)
            => State = state;

        [MethodImpl(Inline)]
        public bit(byte state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(sbyte state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(short state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(ushort state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(int state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(uint state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(long state)
            => State = state != 0;

        [MethodImpl(Inline)]
        public bit(ulong state)
            => State = state != 0;

        /// <summary>
        /// Constructs a disabled bit
        /// </summary>
        public static bit Off
        {
             [MethodImpl(Inline)]
             get => false;
        }

        /// <summary>
        /// Constructs an enabled bit
        /// </summary>
        public static bit On
        {
             [MethodImpl(Inline)]
             get => true;
        }

        [MethodImpl(Inline), Op]
        public char ToChar()
            => (char)(u8(State) + 48);

        [MethodImpl(Inline)]
        public string Format()
            => State ? "1" : "0";

        [MethodImpl(Inline), Op]
        public bool Equals(bit b)
            => State == b.State;

        public override bool Equals(object b)
            => b is bit x && Equals(x);

        public override int GetHashCode()
            => (int)(u8(State));


        public override string ToString()
            => Format();

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator & (bit a, bit b)
            => a.State & b.State;

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator | (bit a, bit b)
            => a.State | b.State;

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator ^ (bit a, bit b)
            => a.State ^ b.State;

        /// <summary>
        /// Combines the states of the source bits
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator + (bit a, bit b)
            => a.State ^ b.State;

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ~(bit a)
            => !a.State;

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator !(bit a)
            => !a.State;

        [MethodImpl(Inline)]
        public static implicit operator bit(bool src)
            => new bit(src);

        [MethodImpl(Inline)]
        static unsafe byte u8(bool on)
            => *((byte*)(&on));

        /// <summary>
        /// Implicitly constructs a bool from a bit
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline)]
        public static implicit operator bool(bit src)
            => src.State;

        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline)]
        public static bool operator true(bit b)
            => b.State == true;

        /// <summary>
        /// Returns false if the bit is disabled, true otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline)]
        public static bool operator false(bit b)
            => b.State == false;

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator byte(bit src)
            => u8(src.State);

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator sbyte(bit src)
            => (sbyte)u8(src.State);

        /// <summary>
        /// Defines an explicit byte -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator bit(byte src)
            => new bit(src);

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator ushort(bit src)
            => (ushort)u8(src.State);

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator short(bit src)
            => (short)u8(src.State);

        /// <summary>
        /// Defines an explicit ushort -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator bit(ushort src)
            => new bit(src);

        /// <summary>
        /// Defines an explicit bit -> int conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator int(bit src)
            => (int)u8(src.State);

        /// <summary>
        /// Defines an *implicit* int -> bit conversion to aid sanity retention
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static implicit operator bit(int src)
            => new bit(src);

        /// <summary>
        /// Defines an explicit bit -> uint conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator uint(bit src)
            => (uint)u8(src.State);

        /// <summary>
        /// Defines an explicit bit -> long conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator long(bit src)
            => (long)u8(src.State);

        /// <summary>
        /// Defines an explicit bit -> float conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator float(bit src)
            => (float)u8(src.State);

        /// <summary>
        /// Defines an explicit bit -> double conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline)]
        public static explicit operator double(bit src)
            => (double)u8(src.State);

        [MethodImpl(Inline)]
        public static implicit operator BitState(bit src)
            => (BitState)u8(src.State);

        [MethodImpl(Inline)]
        public static implicit operator Bit32(bit src)
            => src.State;

        [MethodImpl(Inline)]
        public static implicit operator bit(BitState src)
            => new bit((byte)src);

        [MethodImpl(Inline)]
        public static bool operator ==(bit a, bit b)
            => a.State == b.State;

        [MethodImpl(Inline)]
        public static bool operator !=(bit a, bit b)
            => a.State != b.State;

        [ApiHost(ApiNames.BitLogicBits, true)]
        public struct BitLogic
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