//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public class HexCodes
    {
        [MethodImpl(Inline)]
        public static HexKind kind<H>(H h= default)
            where H : unmanaged, IHexCode
                => h.Kind;

        [MethodImpl(Inline)]
        public static byte value<H>(H h= default)
            where H : unmanaged, IHexCode
                => (byte)h.Kind;                

   }
}