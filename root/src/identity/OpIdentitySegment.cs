//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public readonly struct OpIdentitySegment
    {        
        public static OpIdentitySegment Empty => Define(FixedWidth.None, FixedWidth.None, NumericIndicator.None);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OpIdentitySegment Define(FixedWidth total, FixedWidth segment, NumericIndicator indicator)
            => new OpIdentitySegment(total,segment,indicator);

        public static bool TryParse(string src, out OpIdentitySegment dst)
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
            var parts = src.Substring(startidx).Split(OpIdentity.SegSep,StringSplitOptions.RemoveEmptyEntries);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];
                var segtext = part0[0] == OpIdentity.Generic ? part0.Substring(1, part0.Length - 1): part0;
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
                
        public static OpIdentitySegment Define(int totalwidth, int segwidth, char indicator)
        {
            if(Enum.IsDefined(typeof(FixedWidth),(uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)indicator)
            ) return Define((FixedWidth)totalwidth, (FixedWidth)segwidth, (NumericIndicator)indicator);
            else
                return Empty;
        }

        public static implicit operator OpIdentitySegment((int w, int t, char i) src)                
            => Define(src.w,src.t,src.i);

        public static implicit operator OpIdentitySegment((FixedWidth w, FixedWidth t, NumericIndicator i) src)                
            => new OpIdentitySegment(src.w, src.t,src.i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        OpIdentitySegment(FixedWidth dominant, FixedWidth segwidth, NumericIndicator indicator)
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
            => $"{(int)TotalWidth}{OpIdentity.SegSep}{(int)SegWidth}{(char)Indicator}";

        public override string ToString()
            => Format();
    }
}