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

    using C = AsciCharCode;

    partial class AsciCodes     
    {
        [MethodImpl(Inline), Op]
        public static C kind(AsciCode2 src, byte index)
            => (C)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static C kind(AsciCode4 src, byte index)
            => (C)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static C kind(AsciCode8 src, byte index)
            => (C)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static C kind(AsciCode16 src, byte index)
            => (C)src.Data.GetElement(index);
    }
}