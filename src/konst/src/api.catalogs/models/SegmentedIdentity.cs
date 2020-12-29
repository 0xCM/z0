//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SegmentedIdentity
    {
        [MethodImpl(Inline)]
        public static SegmentedIdentity define(TypeWidth tw, CellWidth segwidth, NumericKind nk)
            => new SegmentedIdentity(tw, segwidth, nk);

        [MethodImpl(Inline)]
        public static SegmentedIdentity define(TypeIndicator indicator, TypeWidth w, NumericKind nk)
            => new SegmentedIdentity(indicator, (CellWidth)w, nk);

        [MethodImpl(Inline)]
        public static SegmentedIdentity define(TypeIndicator indicator, CellWidth w, NumericKind nk)
            => new SegmentedIdentity(indicator, w,nk);

        public TypeWidth TypeWidth {get;}

        public TypeIndicator Indicator {get;}

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

        public static implicit operator SegmentedIdentity((TypeIndicator si, CellWidth w, CellWidth t, NumericIndicator i) src)
            => new SegmentedIdentity(src.si, src.w, ((NumericWidth)src.t).ToNumericKind(src.i));

        [MethodImpl(Inline)]
        public SegmentedIdentity(NumericKind nk)
        {
            Identifier = nk.KeywordNot();
            Indicator = TypeIndicator.Empty;
            SegKind = nk;
            TypeWidth = (TypeWidth)nk.Width();
        }

        [MethodImpl(Inline)]
        internal SegmentedIdentity(string text)
        {
            Identifier = text;
            Indicator = TypeIndicator.Empty;
            SegKind = NumericKind.None;
            TypeWidth = 0;
        }

        [MethodImpl(Inline)]
        public SegmentedIdentity(TypeWidth tw, CellWidth cw, NumericKind nk)
        {
            TypeWidth = tw;
            Indicator = default;
            SegKind = nk;
            Identifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public SegmentedIdentity(TypeIndicator indicator, CellWidth width, NumericKind kind)
        {
            Indicator = indicator;
            TypeWidth = (TypeWidth)width;
            SegKind = kind;
            if(TypeWidth == 0 && kind == 0)
                Identifier = string.Empty;
            else
                Identifier = $"{indicator}{(int)TypeWidth}{IDI.SegSep}{kind.Width()}{(char)kind.Indicator()}";
        }

        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(SegmentedIdentity src)
            => Identifier.Equals(src.Identifier);

        public string Format()
            => Identifier;

        public int CompareTo(SegmentedIdentity src)
            => Identifier.CompareTo(src.Identifier);

         public override int GetHashCode()
            => (int)Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is SegmentedIdentity x && Equals(x);

        public override string ToString()
            => Identifier;

        public static SegmentedIdentity Empty
            => new SegmentedIdentity(TypeIndicator.Empty, CellWidth.None, NumericKind.None);
    }
}