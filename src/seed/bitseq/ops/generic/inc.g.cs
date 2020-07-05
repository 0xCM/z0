//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    using d = BitSeqD;

    partial class BitSeqG
    {
        [MethodImpl(Inline)]
        public static S inc<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
        {
            if(typeof(S) == typeof(uint1))
                return generic<S>(d.inc(uint1(src)));
            else if(match<S,uint2>())
                return generic<S>(d.inc(uint2(src)));
            else if(match<S,uint3>())
                return generic<S>(d.inc(uint3(src)));
            else if(match<S,uint4>())
                return generic<S>(d.inc(uint4(src)));
            else 
                return inc<S>(w5, src);
        }

        [MethodImpl(Inline)]
        static S inc<S>(W5 w5, S src)
            where S : unmanaged, IBitSeq<S,byte>
        {
            if(match<S,uint5>())
                return generic<S>(d.inc(uint5(src)));
            else if(match<S,uint6>())
                return generic<S>(d.inc(uint6(src)));
            else if(match<S,uint7>())
                return generic<S>(d.inc(uint7(src)));
            else if(match<S,octet>())
                return generic<S>(d.inc(uint8(src)));
            else
                throw no<S>();
        }
    }
}