//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;

    partial class AsciCodes     
    {        
        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode src)
            => Symbolic.symbol<AsciChar,byte>(src);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode2 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(code(src,index));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode4 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(code(src,index));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode8 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(code(src,index));
        
        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode16 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(src.Data.GetElement(index));
    }
}