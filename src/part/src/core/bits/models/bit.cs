//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost, Datatype]
    public readonly partial struct bit : ITextual, IEquatable<bit>
    {
        internal readonly bool State;

        public const char Zero = '0';

        public const char One = '1';

        static ReadOnlySpan<byte> _B01 => new byte[2]{0,1};

        public static ReadOnlySpan<bit> Bit01
        {
            [MethodImpl(Inline), Op]
            get => memory.recover<bit>(_B01);
        }

        public static bit[] B01
        {
            [MethodImpl(Inline)]
            get => new bit[]{Off,On};
        }

        [MethodImpl(Inline), Op]
        public static bit parse(char c)
            => c == One;

        [MethodImpl(Inline), Op]
        public static bit parse(string src)
            => parse(text.ifempty(src, "0")[0]);

        [MethodImpl(Inline), Op]
        public static bool parse(string src, out bit dst)
        {
            dst = 0;
            if(text.nonempty(src))
            {
                var c = src[0];
                if(c == Zero)
                {
                    return true;
                }
                else if(c == One)
                {
                    dst = 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

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

        [MethodImpl(Inline)]
        public char ToChar()
            => State ? '1' : '0';

        [MethodImpl(Inline)]
        public string Format()
            => State ? "1" : "0";

        [Ignore]
        string ITextual.Format()
            => Format();

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
        public static implicit operator bit(ParityKind src)
            => new bit((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(bit src)
            => (BinaryDigit)((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator bit(BinaryDigit src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static bool operator ==(bit a, bit b)
            => a.State == b.State;

        [MethodImpl(Inline)]
        public static bool operator !=(bit a, bit b)
            => a.State != b.State;

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
    }
}