//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;
    using static Typed;

    partial struct asci
    {

         
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci2 src)
            => Control.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci4 src)
            => Control.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(asci5 src)
            => Control.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci8 src)
            => Control.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci16 src)
            => Control.cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci32 src)
            => Control.cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci64 src)
            => Control.cast<AsciCodeCover>(bytespan(src)); 
    }
}