//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct memory
    {
        [MethodImpl(Inline), TestBit]
        public static unsafe bool @bool(BitState src)
        {
            var dst = false;
            var pSrc = (byte*)&src;
            var pDst = (byte*)&dst;
            *pDst = *pSrc;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref bool @bool<T>(in T src)
            => ref As<T,bool>(ref edit(src));
    }
}