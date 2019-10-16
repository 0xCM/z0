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

    /// <summary>
    /// Defines the value of a bit
    /// </summary>
    public readonly struct Bit
    {
        readonly bool value;
        
        [MethodImpl(Inline)]
        public Bit(bool value)        
            => this.value = value;

        public static Bit Off => false;

        public static Bit On => true;

        public const char Zero = '0';

        public const char One = '1';

        /// <summary>
        /// The values in the type's domain
        /// </summary>
        public static Bit[] B01 = new Bit[2]{Bit.Off,Bit.On};

        // [MethodImpl(Inline)]
        // public static char And(char a, char b)
        //     => (a == One & b == One) ? One : Zero;

        // [MethodImpl(Inline)]
        // public static char Or(char a, char b)
        //     => (a == One | b == One) ? One : Zero;

        // [MethodImpl(Inline)]
        // public static char XOr(char a, char b)
        //     => (a == One ^ b == One) ? One : Zero;

        // [MethodImpl(Inline)]
        // public static char Flip(char src)
        //     => src == One ? Zero : One;
            
        const string ZeroS = "0";

        const string OneS = "1";
        
        [MethodImpl(Inline)]
        public static Bit Parse(char c)
            => c == One;

        [MethodImpl(Inline)]
        public static implicit operator bool(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Bit(bool src)
            => new Bit(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(Bit src)
            => src.ToByte();

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(byte src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static explicit operator char(Bit src)
            => src ? One : Zero;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator int(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator uint(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator long(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator ulong(Bit src)
            => src.ToByte();

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator Bit(sbyte src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator Bit(short src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Explicitly converts an integral value to a bit where nonzero values are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator Bit(ushort src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Explicitly converts an integral value to a bit where nonzero values are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator Bit(int src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Explicitly converts an integral value to a bit where nonzero values are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator Bit(uint src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static explicit operator BinaryDigit(Bit src)
            => src.value ? BinaryDigit.One : BinaryDigit.Zed;

        [MethodImpl(Inline)]
        public static explicit operator Bit(BinaryDigit src)
            => new Bit(src == BinaryDigit.One);

        [MethodImpl(Inline)]
        public static Bit operator & (Bit a, Bit b) 
            => a.value & b.value;

        [MethodImpl(Inline)]
        public static Bit operator | (Bit a, Bit b) 
            => a.value | b.value;

        [MethodImpl(Inline)]
        public static Bit operator ^ (Bit a, Bit b) 
            => a.value ^ b.value;

        [MethodImpl(Inline)]
        public static Bit operator ~ (Bit src) 
            => ! src.value;

        [MethodImpl(Inline)]
        public static Bit operator ! (Bit src) 
            => !src.value;


        [MethodImpl(Inline)]
        public static bool operator ==(Bit a, Bit b)
            => a.value == b.value;

        [MethodImpl(Inline)]
        public static bool operator !=(Bit a, Bit b)
            => a.value != b.value;

        [MethodImpl(Inline)]
        public static bool operator true(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static bool operator false(Bit src)
            => !src.value;

        [MethodImpl(Inline)]
        public static Bit operator + (Bit a, Bit b) 
            => (a.value,b.value) switch
                {
                    (true, true) => false,
                    (false, false) => false,
                    (false, true) => true,
                    (true, false) => true
                };

        [MethodImpl(Inline)]
        public static Bit operator * (Bit a, Bit b) 
            => (a.value,b.value) switch
                {
                    (true, true) => true,
                    (false, false) => false,
                    (false, true) => false,
                    (true, false) => false
                };

        /// <summary>
        /// Converts a bool to a byte quickly
        /// </summary>
        /// <param name="src"></param>
        /// <remarks>Taken from https://stackoverflow.com/questions/4980881/what-is-fastest-way-to-convert-bool-to-byte</remarks>
        [MethodImpl(Inline)]
        static unsafe byte ToByte(bool src)
            =>  *((byte*)(&src));

        [MethodImpl(Inline)]
        public Bit And(Bit y)
            => value & y.value;

        [MethodImpl(Inline)]
        public Bit Or(Bit y)
            => value | y.value;

        [MethodImpl(Inline)]
        public Bit XOr(Bit y)
            => value ^ y.value;

        [MethodImpl(Inline)]
        public Bit Not()
            => !value;

        [MethodImpl(Inline)]
        public Bit Nand(Bit y)
            => !(value & y.value);

        [MethodImpl(Inline)]
        public Bit Nor(Bit y)
            => !(value | y.value);

        [MethodImpl(Inline)]
        public Bit Xnor(Bit y)
            => !(value ^ y.value);

        [MethodImpl(Inline)]
        public Bit AndNot(Bit y)
            => value & (!y.value);

        [MethodImpl(Inline)]
        public Bit Xor1()
            => !(value ^ true);

        [MethodImpl(Inline)]
        public Bit Select(Bit b, Bit c)
            => value ? b : c;

        [MethodImpl(Inline)]
        public byte ToByte()
            => ToByte(value);

        [MethodImpl(Inline)]
        public bool Equals(Bit b)
            => value == b.value;

        public override bool Equals(object b)
            => b is Bit ? Equals((Bit)b) : false;

        public override int GetHashCode()
            => value ? 1 : 0;
    
        public override string ToString()
            => value  ? OneS : ZeroS;
    }



}