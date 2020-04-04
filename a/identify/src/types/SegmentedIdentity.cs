//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static IdentityShare;

    public readonly struct SegmentedIdentity : IIdentifiedType<SegmentedIdentity>
    {        
        public static SegmentedIdentity Empty => new SegmentedIdentity(TypeIndicator.Empty, FixedWidth.None, NumericKind.None);

        public readonly TypeIndicator Indicator;

        public readonly FixedWidth TypeWidth;

        public readonly NumericKind SegKind;  

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static implicit operator string(SegmentedIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(SegmentedIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(SegmentedIdentity a, SegmentedIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(SegmentedIdentity a, SegmentedIdentity b)
            => !a.Equals(b);

        public static implicit operator SegmentedIdentity((TypeIndicator si, FixedWidth w, FixedWidth t, NumericIndicator i) src)                
            => new SegmentedIdentity(src.si,src.w, src.t.ToNumericKind(src.i));


        [MethodImpl(Inline)]
        internal SegmentedIdentity(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
        {
            this.Indicator = indicator;
            this.TypeWidth = typewidth;
            this.SegKind = segkind;
            this.Identifier 
                = (TypeWidth == 0 && segkind == 0) 
                ? string.Empty 
                : $"{indicator}{(int)TypeWidth}{IDI.SegSep}{segkind.Width()}{(char)segkind.Indicator()}";
        }

        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(SegmentedIdentity src)
            => equals(this, src);
 
        public int CompareTo(SegmentedIdentity src)
            => compare(this, src);

         public override int GetHashCode()
            => hash(this);

        public override bool Equals(object src)
            => equals(this, src);

        public override string ToString()
            => Identifier;
    }
}