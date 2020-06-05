//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
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
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode2 src)
            => cast<AsciCodeCover>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCodeCover> cover(AsciCode4 src)
            => cast<AsciCodeCover>(bytespan(src));
    }
}