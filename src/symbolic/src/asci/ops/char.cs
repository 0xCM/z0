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
        public static char @char(AsciCode src)
            => (char)src;

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode2 src, byte index)
            => (char)kind(src,index);

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode4 src, byte index)
            => (char)kind(src,index);

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode8 src, byte index)
            => (char)kind(src,index);
        
        [MethodImpl(Inline), Op]
        public static char @char(AsciCode16 src, byte index)
            => (char)kind(src,index);
    }
}