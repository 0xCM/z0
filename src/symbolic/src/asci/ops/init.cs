//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;
    using static Control;
    using static Typed;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static asci16 init(N16 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci16(SymBits.vbroadcast(w128, (byte)fill));

        [MethodImpl(Inline), Op]
        public static asci32 init(N32 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci32(SymBits.vbroadcast(w256, (byte)fill));

        [MethodImpl(Inline), Op]
        public static asci64 init(N64 n, AsciCharCode fill = AsciCharCode.Space)
            => new asci64(SymBits.vbroadcast(w512, (byte)fill));
    }
}