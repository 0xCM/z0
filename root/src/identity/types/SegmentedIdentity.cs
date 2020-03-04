//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityShare;
    using static text;

    public readonly struct SegmentedIdentity : ITypeIdentity<SegmentedIdentity>
    {        
        public static SegmentedIdentity Empty => Define(TypeIndicator.Empty, FixedWidth.None, NumericKind.None);

        public readonly TypeIndicator Indicator;

        public readonly FixedWidth TypeWidth;

        public readonly NumericKind SegKind;  

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static SegmentedIdentity Define(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
            => new SegmentedIdentity(indicator, typewidth,segkind);

        public static SegmentedIdentity Define(TypeIndicator si, int totalwidth, int segwidth, char ni)
        {
            if(Enum.IsDefined(typeof(FixedWidth), (uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)ni)
            ) return Define(si, (FixedWidth)totalwidth, ((FixedWidth)segwidth).ToNumericKind((NumericIndicator)ni));
            else
                return Empty;
        }

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
            => SegmentedIdentity.Define(src.si,src.w, src.t.ToNumericKind(src.i));

        [MethodImpl(Inline)]
        SegmentedIdentity(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
        {
            this.Indicator = indicator;
            this.TypeWidth = typewidth;
            this.SegKind = segkind;
            this.Identifier 
                = (TypeWidth.IsNone() && segkind.IsNone()) 
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

        public static bool TryParse(string src, out SegmentedIdentity dst)
        {
            dst = default;
            if(src.Length == 0)
                return false;

            var indicator = TypeIndicator.Define(src[0]);
            var startidx = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(Char.IsDigit(src[i]))
                {
                    startidx = i;
                    break;
                }
            }
            
            var parts = split(slice(src,startidx), IDI.SegSep);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];

                var segtext = part0[0] 
                    == IDI.Generic 
                    ? slice(part0, 1, part0.Length - 1) 
                    : part0;

                if(uint.TryParse(segtext, out var n))
                {
                    if(Enum.IsDefined(typeof(FixedWidth),n))
                    {
                        var bytext = slice(part1,0, part1.Length - 1);                        
                        if(uint.TryParse(bytext, out var by))
                        {                                
                            if(Enum.IsDefined(typeof(FixedWidth), by))
                            {
                                dst = Define(indicator, (FixedWidth)n, ((FixedWidth)by).ToNumericKind((NumericIndicator)part1.Last()));
                                return true;
                            }
                        }
                    }                       
                }
            }
            return false;
        }
    }
}