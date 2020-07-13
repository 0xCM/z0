//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct asci
    {         
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci2 src)
            => recover<AsciCodeCover>(z.bytes(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci4 src)
            => recover<AsciCodeCover>(z.bytes(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci8 src)
            => recover<AsciCodeCover>(z.bytes(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci16 src)
            => recover<AsciCodeCover>(z.bytes(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci32 src)
            => recover<AsciCodeCover>(z.bytes(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci64 src)
            => recover<AsciCodeCover>(z.bytes(src)); 
    }
}