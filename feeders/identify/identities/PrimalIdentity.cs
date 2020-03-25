//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Identify;

    public readonly struct PrimalIdentity : IIdentifiedType<PrimalIdentity>
    {
        public static PrimalIdentity Empty => new PrimalIdentity(string.Empty);

        public string Identifier {get;}            

        public string Keyword {get;}

        [MethodImpl(Inline)]
        internal static PrimalIdentity Define(NumericKind kind, string keyword)
            => new PrimalIdentity(kind,keyword);

        [MethodImpl(Inline)]
        internal static PrimalIdentity Define(string keyword)
            => new PrimalIdentity(keyword);

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


        [MethodImpl(Inline)]
        PrimalIdentity(NumericKind kind, string keyword)
        {
            this.Identifier = NumericIdentity.Define(kind);
            this.Keyword = keyword;
        }

        [MethodImpl(Inline)]
        PrimalIdentity(string keyword)
        {
            this.Identifier = keyword;
            this.Keyword = keyword;
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        IIdentifiedType<PrimalIdentity> Identified => this;
 
        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();
    }
}