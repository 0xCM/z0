//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Konst;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static char decode(in asci2 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(in asci4 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(in asci8 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(in asci16 src, byte index)
            => (char)code(src,index);
    }
}