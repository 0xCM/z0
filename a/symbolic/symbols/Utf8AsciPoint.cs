//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Symbolic;
    
    /// <summary>
    /// Represents the least 8 bits of a unicode code point which, by definition of the encoding,
    /// is equivalent to the 7 ascii bits.
    /// </summary>
    public readonly struct Utf8AsciPoint : IEquatable<Utf8AsciPoint>, IComparable<Utf8AsciPoint>
    {
        public readonly byte Code;

        public static readonly Utf8AsciPoint MinValue = From(0);

        public static readonly Utf8AsciPoint MaxValue = From(127);

        public static IEnumerable<Utf8AsciPoint> All
        {
            get
            {
                for(var i=0; i <= 127; i++)
                    yield return From(i);
            }
        }        
        
        [MethodImpl(Inline)]
        public static Utf8AsciPoint operator &(Utf8AsciPoint a, Utf8AsciPoint b)
            => From(a.Code & b.Code);

        [MethodImpl(Inline)]
        public static Utf8AsciPoint operator |(Utf8AsciPoint a, Utf8AsciPoint b)
            => From(a.Code | b.Code);

        [MethodImpl(Inline)]
        public static Utf8AsciPoint operator ^(Utf8AsciPoint a, Utf8AsciPoint b)
            => From(a.Code ^ b.Code);

        [MethodImpl(Inline)]
        public static Utf8AsciPoint operator ++(Utf8AsciPoint a)
        {
            if(a < MaxValue)
                return From(a.Code + 1);
            else
                return MinValue;
        }

        [MethodImpl(Inline)]
        public static Utf8AsciPoint operator --(Utf8AsciPoint a)
        {
            if(a > MinValue)
                return From(a.Code - 1);
            else
                return MaxValue;
        }

        [MethodImpl(Inline)]
        public static Utf8AsciPoint operator +(Utf8AsciPoint a, Utf8AsciPoint b)
            => From((a.Code + b.Code) % 128);
                    
        [MethodImpl(Inline)]
        public static bool operator == (Utf8AsciPoint a, Utf8AsciPoint b)
            => a.Code == b.Code;

        [MethodImpl(Inline)]
        public static bool operator != (Utf8AsciPoint a, Utf8AsciPoint b)
            => a.Code != b.Code;

        [MethodImpl(Inline)]
        public static bool operator < (Utf8AsciPoint a, Utf8AsciPoint b)
            => a.Code < b.Code;

        [MethodImpl(Inline)]
        public static bool operator <= (Utf8AsciPoint a, Utf8AsciPoint b)
            => a.Code <= b.Code;

        [MethodImpl(Inline)]
        public static bool operator > (Utf8AsciPoint a, Utf8AsciPoint b)
            => a.Code > b.Code;

        [MethodImpl(Inline)]
        public static bool operator >= (Utf8AsciPoint a, Utf8AsciPoint b)
            => a.Code >= b.Code;

        [MethodImpl(Inline)]
        public static implicit operator char (Utf8AsciPoint src)
            => src.ToChar();

        [MethodImpl(Inline)]
        public static implicit operator byte (Utf8AsciPoint src)
            => src.Code;
    
        [MethodImpl(Inline)]
        internal static Utf8AsciPoint From(int src)
            => new Utf8AsciPoint((byte)src);

        [MethodImpl(Inline)]
        internal Utf8AsciPoint(byte code)
            => this.Code = code;

        [MethodImpl(Inline)]
        public char ToChar()
            => (char)Code;          

        public bool IsSymbol
        {
            [MethodImpl(Inline)]
            get => Char.IsSymbol((char)Code);
        }

        public bool IsControl
        {
            [MethodImpl(Inline)]
            get => Char.IsControl((char)Code);
        }

        public bool IsPunctuation
        {
            [MethodImpl(Inline)]
            get => Char.IsPunctuation((char)Code);
        }

        public bool IsDigit
        {
            [MethodImpl(Inline)]
            get => Char.IsDigit((char)Code);
        }

        public bool IsWhiteSpace
        {
            [MethodImpl(Inline)]
            get => Char.IsWhiteSpace((char)Code);
        }

        public bool IsLetter
        {
            [MethodImpl(Inline)]
            get => Char.IsLetter((char)Code);
        }

        public bool IsLower
        {
            [MethodImpl(Inline)]
            get => Char.IsLower((char)Code);
        }

        public bool IsUpper
        {
            [MethodImpl(Inline)]
            get => Char.IsUpper((char)Code);
        }

        [MethodImpl(Inline)]
        public bool Equals(Utf8AsciPoint b)
            => Code == b.Code;

        [MethodImpl(Inline)]
        public int CompareTo(Utf8AsciPoint b)
            => Code.CompareTo(b.Code);

        public override bool Equals(object obj)
            => obj is Utf8AsciPoint p && Equals(p);

        public override int GetHashCode()
            => Code.GetHashCode();


        public override string ToString() 
        {
            var num = Code.ToString("0x");
            var str = IsControl ? "___"  : $"'{ToChar()}'";
            return $"{num} {str}";
        }
    }
}