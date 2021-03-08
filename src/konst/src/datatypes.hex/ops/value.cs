//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Hex
    {
        [MethodImpl(Inline)]
        public static byte value<H>(H h= default)
            where H : unmanaged, IHexType
                => (byte)h.Value;
    }
}