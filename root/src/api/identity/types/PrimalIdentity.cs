//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityShare;

    public interface IPrimalIdentity : IIdentifiedType<PrimalIdentity>
    {

    }

    public readonly struct PrimalIdentity  : IPrimalIdentity
    {
        public static PrimalIdentity Empty => new PrimalIdentity(string.Empty);

        public string Identifier {get;}            

        public string Keyword {get;}

        [MethodImpl(Inline)]
        public static PrimalIdentity From(Type t)
            => t.IsSystemType() ? 
               ( t.IsNumeric()
               ? new PrimalIdentity(t.NumericKind(), t.SystemKeyword())
               : new PrimalIdentity(t.SystemKeyword())
               )
               : Empty;

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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(PrimalIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(PrimalIdentity other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;
    }
}