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
        public static AsciCodeCover cover(asci2 src, byte index)
            => (byte)(src.Storage >> index);

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(asci4 src, byte index)
            => (byte)(src.Storage >> index);

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(asci5 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(asci5 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(in asci16 src, byte index)
            => (AsciCodeCover)src.Storage.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(asci2 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(asci4 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static AsciCodeCover cover(asci8 src, byte index)
            => (byte)(src.Storage >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(asci8 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci16 src)
            => cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci32 src)
            => cast<AsciCodeCover>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(in asci64 src)
            => cast<AsciCodeCover>(bytespan(src)); 
    }
}