//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S1 = uint1;
    using S2 = uint2;
    using S3 = uint3;
    using S4 = uint4;
    using S5 = uint5;
    using S6 = uint6;
    using S7 = uint7;
    using S8 = octet;
    using d = BitSeqD;

    using static Typed;

    partial class BitSeqG
    {
        [MethodImpl(Inline)]
        public static S inc<S>(in S src)
            where S : unmanaged, IBitSeq<S>
        {
            if(match<S,S1>())
                return edit<S>(d.inc(uint1(src)));
            else if(match<S,S2>())
                return edit<S>(d.inc(uint2(src)));
            else if(match<S,S3>())
                return edit<S>(d.inc(uint3(src)));
            else if(match<S,S4>())
                return edit<S>(d.inc(uint4(src)));
            else 
                return inc(w5, src);
        }

        [MethodImpl(Inline)]
        static S inc<S>(W5 w5, in S src)
            where S : unmanaged, IBitSeq<S>
        {
            if(match<S,S5>())
                return edit<S>(d.inc(uint5(src)));
            else if(match<S,S6>())
                return edit<S>(d.inc(uint6(src)));
            else if(match<S,S7>())
                return edit<S>(d.inc(uint7(src)));
            else if(match<S,S8>())
                return edit<S>(d.inc(uint8(src)));
            else
                throw no<S>();
        }
    }
}