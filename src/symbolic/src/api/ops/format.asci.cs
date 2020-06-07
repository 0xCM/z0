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
        public static string format(in asci2 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in asci4 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in asci5 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in asci8 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in asci16 src)
            => AsciCodes.format(src);        

        [MethodImpl(Inline), Op]
        public static string format(in asci32 src)
            => AsciCodes.format(src);

        [MethodImpl(Inline), Op]
        public static string format(in asci64 src)
            => AsciCodes.format(src);
    }
}