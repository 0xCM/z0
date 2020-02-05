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
        static SegmentedIdentity Define(char si, int totalwidth, int segwidth, char ni)
        {
            if(Enum.IsDefined(typeof(FixedWidth),(uint)totalwidth) &&
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
        public static bool operator==(SegmentedIdentity a, SegmentedIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(SegmentedIdentity a, SegmentedIdentity b)
            => !a.Equals(b);

        public static implicit operator SegmentedIdentity((char si, int w, int t, char i) src)                
            => Define(src.si,src.w,src.t,src.i);

        public static implicit operator SegmentedIdentity((char si, FixedWidth w, FixedWidth t, NumericIndicator i) src)                
            => SegmentedIdentity.Define(src.si,src.w, src.t.ToNumericKind(src.i));

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
                                dst = Define('v', (FixedWidth)n, ((FixedWidth)by).ToNumericKind((NumericIndicator)part1.Last()));
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
