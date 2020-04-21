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
        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> Identify(OpIdentity src, int partidx)
            => from p in Z0.Identify.Part(src, partidx)
                from s in SegmentedIdentity.Identify(p)
                select s;

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> Identify(IdentityPart part)
        {
            if(part.IsSegment && Segmentation.TryParse(part.Identifier, out var seg))
                return seg;
            else
                return Option.none<SegmentedIdentity>();
        }

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