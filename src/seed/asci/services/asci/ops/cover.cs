//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static Typed;

    partial struct asci
    {         
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci2 src)
            => Root.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci4 src)
            => Root.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(asci5 src)
            => Root.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci8 src)
            => Root.cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci16 src)
            => Root.cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci32 src)
            => Root.cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci64 src)
            => Root.cast<AsciCodeCover>(bytespan(src)); 
    }
}