//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly partial struct SegmentedIdentity : ITypeIdentity<SegmentedIdentity>
    {        
        public readonly char TypeIndicator;

        public readonly FixedWidth TypeWidth;

        public readonly NumericKind SegKind;  

        public string Identifier {get;}

        public static SegmentedIdentity Empty => Define('q', FixedWidth.None, NumericKind.None);

        [MethodImpl(Inline)]
        public static SegmentedIdentity Define(char indicator, FixedWidth typewidth, NumericKind segkind)
            => new SegmentedIdentity(indicator, typewidth,segkind);

        [MethodImpl(Inline)]
        SegmentedIdentity(char indicator, FixedWidth typewidth, NumericKind segkind)
        {
            this.TypeIndicator = indicator;
            this.TypeWidth = typewidth;
            this.SegKind = segkind;
            this.Identifier 
                = (TypeWidth.IsNone() && segkind.IsNone()) 
                ? string.Empty 
                : $"{(int)TypeWidth}{IDI.SegSep}{segkind.Width()}{(char)segkind.GetNumericIndicator()}";

        }

        [MethodImpl(Inline)]
        public bool Equals(TypeIdentity src)
            => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

    }
}