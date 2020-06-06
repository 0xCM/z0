//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode2 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(cover(src,index));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode4 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(cover(src, index));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode5 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(cover(src,index));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode8 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(cover(src,index));

    }
}