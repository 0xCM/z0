//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static IdentityShare;

    public readonly struct SegmentedIdentity : IIdentifiedType<SegmentedIdentity>
    {        
        public static SegmentedIdentity identify(TypeIndicator si, int totalwidth, int segwidth, char ni)
        {
            if(Enum.IsDefined(typeof(FixedWidth), (uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)ni)
            ) return identify(si, (FixedWidth)totalwidth, ((NumericWidth)segwidth).ToNumericKind((NumericIndicator)ni));
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        public static SegmentedIdentity identify(TypeIndicator indicator, TypeWidth w, NumericKind nk)
            => new SegmentedIdentity(indicator, (FixedWidth)w, nk);

        [MethodImpl(Inline)]
        public static SegmentedIdentity identify(TypeIndicator indicator, FixedWidth w, NumericKind nk)
            => new SegmentedIdentity(indicator, w,nk);

        public TypeIndicator Indicator {get;}

        public FixedWidth TypeWidth {get;}

        public NumericKind SegKind {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static SegmentedIdentity from(string text)
            => new SegmentedIdentity(text);
            
        [MethodImpl(Inline)]
        public static implicit operator SegmentedIdentity(NumericKind src)
            => new SegmentedIdentity(src);

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
            => new SegmentedIdentity(src.si, src.w, ((NumericWidth)src.t).ToNumericKind(src.i));

        [MethodImpl(Inline)]
        public SegmentedIdentity(NumericKind nk)
        {
            Identifier = nk.KeywordNot();
            Indicator = TypeIndicator.Empty;
            SegKind = nk;
            TypeWidth = (FixedWidth)nk.Width();
        }

        [MethodImpl(Inline)]
        internal SegmentedIdentity(string text)
        {
            Identifier = text;
            Indicator = TypeIndicator.Empty;
            SegKind = NumericKind.None;
            TypeWidth = FixedWidth.None;
        }

        [MethodImpl(Inline)]
        public SegmentedIdentity(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
        {
            Indicator = indicator;
            TypeWidth = typewidth;
            SegKind = segkind;
            if(TypeWidth == 0 && segkind == 0)
                Identifier = string.Empty;
            else
                Identifier = $"{indicator}{(int)TypeWidth}{IDI.SegSep}{segkind.Width()}{(char)segkind.Indicator()}";
        }

        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(SegmentedIdentity src)
            => equals(this, src);
    
        public string Format()
            => Identifier;

        public int CompareTo(SegmentedIdentity src)
            => compare(this, src);

         public override int GetHashCode()
            => hash(this);

        public override bool Equals(object src)
            => equals(this, src);

        public override string ToString()
            => Identifier;

        public static SegmentedIdentity Empty 
            => new SegmentedIdentity(TypeIndicator.Empty, FixedWidth.None, NumericKind.None);
    }
}