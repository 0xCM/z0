//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static string format(in AsciCode2 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode4 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode5 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode8 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode16 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode32 src)
            => AsciCodes.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode64 src)
            => AsciCodes.format(src);
    }
}