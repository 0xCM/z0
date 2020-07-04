//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct xHex
    {
        [MethodImpl(Inline)]
        public static HexKind8 kind<H>(H h= default)
            where H : unmanaged, IHexType
                => h.Value;
    }
}