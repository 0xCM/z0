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

    partial struct SegmentedIdentity
    {        
        public static SegmentedIdentity Define(int totalwidth, int segwidth, char indicator)
        {
            if(Enum.IsDefined(typeof(FixedWidth),(uint)totalwidth) &&
                Enum.IsDefined(typeof(FixedWidth),(uint)segwidth) &&
                Enum.IsDefined(typeof(NumericIndicator), (ushort)indicator)
            ) return Define((FixedWidth)totalwidth, (FixedWidth)segwidth, (NumericIndicator)indicator);
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator string(SegmentedIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(SegmentedIdentity a, SegmentedIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(SegmentedIdentity a, SegmentedIdentity b)
            => !a.Equals(b);

        public static implicit operator SegmentedIdentity((int w, int t, char i) src)                
            => Define(src.w,src.t,src.i);

        public static implicit operator SegmentedIdentity((FixedWidth w, FixedWidth t, NumericIndicator i) src)                
            => new SegmentedIdentity(src.w, src.t,src.i);

        public static bool TryParse(string src, out SegmentedIdentity dst)
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
            var parts = src.Substring(startidx).Split(TypeIdentity.SegSep,StringSplitOptions.RemoveEmptyEntries);
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
    }
}
