//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct PrimalIdentity : IIdentifiedType<PrimalIdentity>
    {
        public string Identifier {get;}

        public string Keyword {get;}

        [MethodImpl(Inline)]
        internal PrimalIdentity(NumericKind kind, string keyword)
        {
            this.Identifier = NumericIdentity.Define(kind);
            this.Keyword = keyword;
        }

        [MethodImpl(Inline)]
        internal PrimalIdentity(string keyword)
        {
            this.Identifier = keyword;
            this.Keyword = keyword;
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.define(Identifier);

        IIdentifiedType<PrimalIdentity> Identified => this;

        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        [MethodImpl(Inline)]
        public static implicit operator string(PrimalIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(PrimalIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(PrimalIdentity a, PrimalIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(PrimalIdentity a, PrimalIdentity b)
            => !a.Equals(b);

        public static PrimalIdentity Empty => new PrimalIdentity(EmptyString);
    }
}