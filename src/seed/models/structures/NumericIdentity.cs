//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NumericIdentity : IIdentifiedType<NumericIdentity>
    {
        public string Identifier {get;}            

        public NumericKind NumericKind {get;}           

        [MethodImpl(Inline)]
        public static NumericIdentity Define(NumericKind kind)
            => new NumericIdentity(kind);

        [MethodImpl(Inline)]
        public static implicit operator string(NumericIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(NumericIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(NumericIdentity a, NumericIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(NumericIdentity a, NumericIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        NumericIdentity(NumericKind kind)
        {
            this.NumericKind = kind;
            this.Identifier = $"{kind.TypeWidth().FormatValue()}{NumericKind.Indicator().Format()}";
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        IIdentifiedType<NumericIdentity> Identified => this;
 
        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();
    }
}