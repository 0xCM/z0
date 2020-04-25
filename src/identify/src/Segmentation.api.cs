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

    public static class Segmentation
    {
        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> identify(IdentityPart part)
        {
            if(part.IsSegment && Segmentation.TryParse(part.Identifier, out var seg))
                return seg;
            else
                return Option.none<SegmentedIdentity>();
        }

        [MethodImpl(Inline)]
        public static SegmentedIdentity identify(TypeIndicator indicator, TypeWidth wk, NumericKind segkind)
            => new SegmentedIdentity(indicator, (FixedWidth)wk, segkind);

        [MethodImpl(Inline)]
        public static SegmentedIdentity identify(TypeIndicator indicator, FixedWidth typewidth, NumericKind segkind)
            => new SegmentedIdentity(indicator, typewidth,segkind);

        public static SegmentedIdentity identify(TypeIndicator si, int totalwidth, int segwidth, char ni)
        {
            if(Enum.IsDefined(typeof(FixedWidth), (uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)ni)
            ) return identify(si, (FixedWidth)totalwidth, ((NumericWidth)segwidth).ToNumericKind((NumericIndicator)ni));
            else
                return SegmentedIdentity.Empty;
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
                if(Char.IsDigit(src[i]))
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
    }
}