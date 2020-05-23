//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct B00 : IDuet<B00>
    {
        public const string TypeName = "B00";

        public const string ValueName = "b00";
            
        [MethodImpl(Inline)]
        public static implicit operator byte(B00 src) => (byte)src.Kind;

        // [MethodImpl(Inline)]
        // public static implicit operator duet(B00 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Duet(B00 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Triad(B00 src) => (Triad)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quartet(B00 src) => (Quartet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quintet(B00 src) => (Quintet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Octet(B00 src) => (Octet)src.Kind;

        public Duet Kind => Duet.b00;

        [MethodImpl(Inline)]
        public string Format() => ValueName;

        public override string ToString() => ValueName;
    }

    public readonly struct B01 : IDuet<B01>
    {
        public const string TypeName = "B01";

        public const string ValueName = "b01";
            
        [MethodImpl(Inline)]
        public static implicit operator byte(B01 src) => (byte)src.Kind;

        // [MethodImpl(Inline)]
        // public static implicit operator duet(B01 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Duet(B01 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Triad(B01 src) => (Triad)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quartet(B01 src) => (Quartet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quintet(B01 src) => (Quintet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Octet(B01 src) => (Octet)src.Kind;

        public Duet Kind => Duet.b01;

        [MethodImpl(Inline)]
        public string Format() => ValueName;

        public override string ToString() => ValueName;        
    }    

    public readonly struct B10 : IDuet<B10>
    {
        public const string TypeName = "B10";

        public const string ValueName = "b10";
            
        [MethodImpl(Inline)]
        public static implicit operator byte(B10 src) => (byte)src.Kind;

        // [MethodImpl(Inline)]
        // public static implicit operator duet(B10 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Duet(B10 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Triad(B10 src) => (Triad)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quartet(B10 src) => (Quartet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quintet(B10 src) => (Quintet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Octet(B10 src) => (Octet)src.Kind;

        public Duet Kind => Duet.b10;

        [MethodImpl(Inline)]
        public string Format() => ValueName;

        public override string ToString() => ValueName;
    }

    public readonly struct B11 : IDuet<B11>
    {
        public const string TypeName = "B11";

        public const string ValueName = "b11";
            
        [MethodImpl(Inline)]
        public static implicit operator byte(B11 src) => (byte)src.Kind;

        // [MethodImpl(Inline)]
        // public static implicit operator duet(B11 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Duet(B11 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Triad(B11 src) => (Triad)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quartet(B11 src) => (Quartet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quintet(B11 src) => (Quintet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Octet(B11 src) => (Octet)src.Kind;

        public Duet Kind => Duet.b11;

        [MethodImpl(Inline)]
        public string Format() => ValueName;

        public override string ToString() => ValueName;
    }     
}