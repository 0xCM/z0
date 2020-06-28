//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Symbolic
    {
        [MethodImpl(Inline)]
        public static HexKind8 hexkind<H>(H h= default)
            where H : unmanaged, IHexCode
                => h.Kind;

        [MethodImpl(Inline)]
        public static byte hexval<H>(H h= default)
            where H : unmanaged, IHexCode
                => (byte)h.Kind;                
    }
}