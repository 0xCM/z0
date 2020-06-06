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

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode2 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode4 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode8 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode16 src, byte index)
            => (char)code(src,index);
    }
}