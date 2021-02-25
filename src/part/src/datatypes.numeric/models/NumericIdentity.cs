//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NumericIdentity : IIdentifiedType<NumericIdentity>
    {
        public string Identifier {get;}

        public NumericKind NumericKind {get;}

        [MethodImpl(Inline)]
        public static NumericIdentity define(NumericKind kind)
            => new NumericIdentity(kind);

        [MethodImpl(Inline)]
        NumericIdentity(NumericKind kind)
        {
            NumericKind = kind;
            Identifier = $"{kind.TypeWidth().FormatValue()}{NumericKind.Indicator().Format()}";
        }

        IIdentifiedType<NumericIdentity> Identified => this;

        public override int GetHashCode()
            => (int)alg.hash.calc(Identifier);

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        [MethodImpl(Inline)]
        public static implicit operator string(NumericIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(NumericIdentity src)
            => new TypeIdentity(src.Identifier);

        [MethodImpl(Inline)]
        public static bool operator==(NumericIdentity a, NumericIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(NumericIdentity a, NumericIdentity b)
            => !a.Equals(b);
    }
}