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
        public static AsciCode16 init(N16 n, AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode16(SymBits.vbroadcast(w128, (byte)fill));

        [MethodImpl(Inline), Op]
        public static AsciCode32 init(N32 n, AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode32(SymBits.vbroadcast(w256, (byte)fill));

        [MethodImpl(Inline), Op]
        public static AsciCode64 init(N64 n, AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode64(SymBits.vbroadcast(w512, (byte)fill));

    }
}