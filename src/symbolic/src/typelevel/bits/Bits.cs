//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct B0 : IBit<B0>
    {
        public const string TypeName = "B0";

        public const string ValueName = "b0";
            
        [MethodImpl(Inline)]
        public static implicit operator byte(B0 src) => (byte)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator BitKind(B0 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Duet(B0 src) => (Duet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Triad(B0 src) => (Triad)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quartet(B0 src) => (Quartet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quintet(B0 src) => (Quintet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Octet(B0 src) => (Octet)src.Kind;

        public BitKind Kind => BitKind.b0;

        [MethodImpl(Inline)]
        public string Format() => ValueName;

        public override string ToString() => ValueName;
    }

    public readonly struct B1 : IBit<B1>
    {
        public const string TypeName = "B1";

        public const string ValueName = "b1";
            
        [MethodImpl(Inline)]
        public static implicit operator byte(B1 src) => (byte)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator BitKind(B1 src) => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Duet(B1 src) => (Duet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Triad(B1 src) => (Triad)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quartet(B1 src) => (Quartet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Quintet(B1 src) => (Quintet)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator Octet(B1 src) => (Octet)src.Kind;

        public BitKind Kind => BitKind.b1;

        [MethodImpl(Inline)]
        public string Format() => ValueName;

        public override string ToString() => ValueName;        
    }    
}