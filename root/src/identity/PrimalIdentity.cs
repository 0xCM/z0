//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityCommons;

    public readonly struct PrimalIdentity  : ITypeIdentity<PrimalIdentity>
    {
        public static PrimalIdentity Empty => new PrimalIdentity(string.Empty);

        [MethodImpl(Inline)]
        public static PrimalIdentity From(Type t)
            => t.IsPrimal() ? 
               ( t.IsNumeric()
               ? new PrimalIdentity(t.NumericKind(), t.PrimitiveKeyword())
               : new PrimalIdentity(t.PrimitiveKeyword())
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
            this.Identifier = ScalarIdentity.Define(kind);
            this.Keyword = keyword;
        }

        [MethodImpl(Inline)]
        PrimalIdentity(string keyword)
        {
            this.Identifier = keyword;
            this.Keyword = keyword;
        }

        public string Identifier {get;}            

        public string Keyword {get;}           

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
            => IdentityEquals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(PrimalIdentity other)
            => IdentityCompare(this, other);
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        public override string ToString()
            => Identifier;

    }
}