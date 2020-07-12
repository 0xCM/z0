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
    
    using Q = Z0;
    
    partial class Bit
    {
        [MethodImpl(Inline), Op]
        public static uint4 max(W4 w)
            => max<uint4,byte>();

        [MethodImpl(Inline), Op]
        public static uint6 max(W6 w)
            => max<uint6,byte>();

        [MethodImpl(Inline), Op]
        public static uint7 max(W7 w)
            => max<uint7,byte>();

        [MethodImpl(Inline)]
        static S max<S,T>()
            where S : unmanaged, ISmalInt<S,T>
            where T : unmanaged
        {
            if(match<S,uint1>())
                return cast<S>(Q.uint1.MaxVal);
            else if(match<S,uint2>())
                return cast<S>(Q.uint2.MaxVal);
            else if(match<S,uint3>())
                return cast<S>(Q.uint3.MaxVal);
            else if(match<S,uint4>())
                return cast<S>(Q.uint4.MaxVal);
            else 
                return max<S,T>(w5);
        }

        [MethodImpl(Inline)]
        static S max<S,T>(W5 w5)
            where S : unmanaged, ISmalInt<S,T>
            where T : unmanaged
        {
            if(match<S,uint5>())
                return cast<S>(Q.uint5.MaxVal);
            else if(match<S,uint6>())
                return cast<S>(Q.uint6.MaxVal);
            else if(match<S,uint7>())
                return cast<S>(Q.uint7.MaxVal);
            else if(match<S,octet>())
                return cast<S>(Q.octet.MaxVal);
            else
                throw no<S>();
        }
    }
}