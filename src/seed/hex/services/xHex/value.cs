//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    partial struct xHex
    {
        [MethodImpl(Inline)]
        public static byte value<H>(H h= default)
            where H : unmanaged, IHexType
                => (byte)h.Value;
    }
}