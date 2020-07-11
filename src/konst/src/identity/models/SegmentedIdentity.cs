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
        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> identify(IdentityPart part)
        {
            if(part.IsSegment && TryParse(part.Identifier, out var seg))
                return seg;
            else
                return z.none<SegmentedIdentity>();
        }

        public static bool TryParse(string src, out SegmentedIdentity dst)
        {
            dst = default;
            if(src.Length == 0)
                return false;

            var indicator = TypeIndicator.Define(src[0]);
            var startidx = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(char.IsDigit(src[i]))
                {
                    startidx = i;
                    break;
                }
            }
            
            var parts = text.split(text.slice(src,startidx), IDI.SegSep);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];

                var segtext = part0[0] 
                    == IDI.Generic 
                    ? text.slice(part0, 1, part0.Length - 1) 
                    : part0;

                if(uint.TryParse(segtext, out var n))
                {
                    if(Enum.IsDefined(typeof(FixedWidth),n))
                    {
                        var bytext = text.slice(part1,0, part1.Length - 1);                        
                        if(uint.TryParse(bytext, out var by))
                        {                                
                            if(Enum.IsDefined(typeof(FixedWidth), by))
                            {
                                dst = identify(indicator, (FixedWidth)n, ((NumericWidth)by).ToNumericKind((NumericIndicator)part1.Last()));
                                return true;
                            }
                        }
                    }                       
                }
            }
            return false;
        }

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
        public static SegmentedIdentity identify(TypeIndicator indicator, TypeWidth wk, NumericKind segkind)
            => new SegmentedIdentity(indicator, (FixedWidth)wk, segkind);

        [MethodImpl(Inline)]
        public static SegmentedIdentity identify(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
            => new SegmentedIdentity(indicator, typewidth,segkind);

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