//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Hex
    {
        [MethodImpl(Inline)]
        public static Hex8Kind kind<H>(H h= default)
            where H : unmanaged, IHexType
                => h.Value;
    }
}