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
        public static AsciCodeCover cover(AsciCode2 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(AsciCode4 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(AsciCode5 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode5 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(in AsciCode16 src, byte index)
            => (AsciCodeCover)src.Data.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode2 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode4 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(AsciCode8 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode8 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in AsciCode16 src)
            => cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in AsciCode32 src)
            => cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in AsciCode64 src)
            => cast<AsciCodeCover>(bytespan(src)); 
    }
}