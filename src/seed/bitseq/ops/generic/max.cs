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

    using X = Z0;

    partial class BitSeqG
    {
        [MethodImpl(Inline)]
        public static S max<S,T>()
            where S : unmanaged, IBitSeq<S,T>
            where T : unmanaged
        {
            if(match<S,uint1>())
                return cast<S>(X.uint1.MaxVal);
            else if(match<S,uint2>())
                return cast<S>(X.uint2.MaxVal);
            else if(match<S,uint3>())
                return cast<S>(X.uint3.MaxVal);
            else if(match<S,uint4>())
                return cast<S>(X.uint4.MaxVal);
            else 
                return max<S,T>(w5);
        }

        [MethodImpl(Inline)]
        static S max<S,T>(W5 w5)
            where S : unmanaged, IBitSeq<S,T>
            where T : unmanaged
        {
            if(match<S,uint5>())
                return cast<S>(X.uint5.MaxVal);
            else if(match<S,uint6>())
                return cast<S>(X.uint6.MaxVal);
            else if(match<S,uint7>())
                return cast<S>(X.uint7.MaxVal);
            else if(match<S,octet>())
                return cast<S>(X.octet.MaxVal);
            else
                throw no<S>();
        }
    }
}