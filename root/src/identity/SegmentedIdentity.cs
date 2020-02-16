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
        public readonly TypeIndicator Indicator;

        public readonly FixedWidth TypeWidth;

        public readonly NumericKind SegKind;  

        public string Identifier {get;}

        public static SegmentedIdentity Empty => Define(TypeIndicator.Empty, FixedWidth.None, NumericKind.None);

        [MethodImpl(Inline)]
        public static SegmentedIdentity Define(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
            => new SegmentedIdentity(indicator, typewidth,segkind);

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

        // public static implicit operator SegmentedIdentity((TypeIndicator si, int w, int t, char i) src)                
        //     => Define(src.si, src.w,src.t, src.i);

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
            => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);

        static SegmentedIdentity Define(TypeIndicator si, int totalwidth, int segwidth, char ni)
        {
            if(Enum.IsDefined(typeof(FixedWidth),(uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)ni)
            ) return Define(si, (FixedWidth)totalwidth, ((FixedWidth)segwidth).ToNumericKind((NumericIndicator)ni));
            else
                return Empty;
        }

        public static bool TryParse(string src, out SegmentedIdentity dst)
        {
            dst = default;
            if(src.Length == 0)
                return false;

            var indicator = Z0.TypeIndicator.Define(src[0]);
            var startidx = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(Char.IsDigit(src[i]))
                {
                    startidx = i;
                    break;
                }
            }
            var parts = src.Substring(startidx).Split(IDI.SegSep, StringSplitOptions.RemoveEmptyEntries);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];
                var segtext = part0[0] == IDI.Generic ? part0.Substring(1, part0.Length - 1): part0;
                if(uint.TryParse(segtext, out var n))
                {
                    if(Enum.IsDefined(typeof(FixedWidth),n))
                    {
                        var bytext = part1.Substring(0, part1.Length - 1);
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