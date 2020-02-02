//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct MonikerSegment
    {        
        public static MonikerSegment Empty => Define(FixedWidth.None, FixedWidth.None, NumericIndicator.None);

        public static MonikerSegment Define(FixedWidth total, FixedWidth segment, NumericIndicator indicator)
            => new MonikerSegment(total,segment,indicator);

        public static bool TryParse(string src, out MonikerSegment dst)
        {
            dst = default;
            var startidx = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(Char.IsDigit(src[i]))
                {
                    startidx = i;
                    break;
                }
            }
            var parts = src.Substring(startidx).Split(Moniker.SegSep,StringSplitOptions.RemoveEmptyEntries);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];
                var segtext = part0[0] == Moniker.Generic ? part0.Substring(1, part0.Length - 1): part0;
                if(uint.TryParse(segtext, out var n))
                {
                    if(Enum.IsDefined(typeof(FixedWidth),n))
                    {
                        var bytext = part1.Substring(0, part1.Length - 1);
                        if(uint.TryParse(bytext, out var by))
                        {                                
                            if(Enum.IsDefined(typeof(FixedWidth), by))
                            {
                                dst = Define((FixedWidth)n, (FixedWidth)by, (NumericIndicator)part1.Last());
                                return true;
                            }
                        }
                    }                       
                }
            }
            return false;
        }
                
        public static MonikerSegment Define(int totalwidth, int segwidth, char indicator)
        {
            if(Enum.IsDefined(typeof(FixedWidth),(uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)indicator)
            ) return Define((FixedWidth)totalwidth, (FixedWidth)segwidth, (NumericIndicator)indicator);
            else
                return Empty;
        }

        public static implicit operator MonikerSegment((int w, int t, char i) src)                
            => Define(src.w,src.t,src.i);

        public static implicit operator MonikerSegment((FixedWidth w, FixedWidth t, NumericIndicator i) src)                
            => new MonikerSegment(src.w, src.t,src.i);

        MonikerSegment(FixedWidth dominant, FixedWidth segwidth, NumericIndicator indicator)
        {
            this.TotalWidth = dominant;
            this.SegWidth = segwidth;
            this.Indicator = indicator;
        }
        
        public readonly FixedWidth TotalWidth;

        public readonly FixedWidth SegWidth;

        public readonly NumericIndicator Indicator;

        public bool IsEmpty
            => TotalWidth == FixedWidth.None &&
                SegWidth == FixedWidth.None &&
                Indicator == NumericIndicator.None;

        public string Format()
            => $"{(int)TotalWidth}{Moniker.SegSep}{(int)SegWidth}{(char)Indicator}";

        public override string ToString()
            => Format();
    }
}