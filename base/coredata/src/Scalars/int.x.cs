//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics; 
    using static zfunc;

    public static class IntX
    {

        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVector128(this UInt128 src)
            => src;

        [MethodImpl(Inline)]
        public static UInt128 ToUInt128(this Vector128<ulong> src)
            => src;

    }
}
     