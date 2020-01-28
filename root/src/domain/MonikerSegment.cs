//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    public readonly struct MonikerSegment
    {        
        public static MonikerSegment Empty => Define(FixedWidth.None, FixedWidth.None, NumericIndicator.None);

        public static bool TryParse(string src, out MonikerSegment dst)
        {
            dst = default;
            var parts = src.Split(Moniker.SegSep);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];
                var segtext = part0[0] == Moniker.GenericIndicator ? part0.Substring(1, part0.Length - 1): part0;
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
                
        public static implicit operator MonikerSegment((int w, int t, char i) src)                
        {
            if( Enum.IsDefined(typeof(FixedWidth),(uint)src.w) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)src.t) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)src.i))
                return Define((FixedWidth)src.w, 
                    (FixedWidth)src.t, 
                    (NumericIndicator)src.i);
                else
                    return Empty;
        }

        public static implicit operator MonikerSegment((FixedWidth w, FixedWidth t, NumericIndicator i) src)                
            => new MonikerSegment(src.w, src.t,src.i);

        public static MonikerSegment Define(FixedWidth dominant, FixedWidth segwidth, NumericIndicator indicator)
            => new MonikerSegment(dominant,segwidth,indicator);

        MonikerSegment(FixedWidth dominant, FixedWidth segwidth, NumericIndicator indicator)
        {
            this.DominantWidth = dominant;
            this.SegmentWidth = segwidth;
            this.Indicator = indicator;
        }
        
        public readonly FixedWidth DominantWidth;

        public readonly FixedWidth SegmentWidth;

        public readonly NumericIndicator Indicator;

        public bool IsEmpty
            => DominantWidth == FixedWidth.None &&
                SegmentWidth == FixedWidth.None &&
                Indicator == NumericIndicator.None;

        public override string ToString()
            => $"{(int)DominantWidth}{Moniker.SegSep}{(int)SegmentWidth}{(char)Indicator}";
    }
}