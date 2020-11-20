//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct SmallHex
    {
        [MethodImpl(Inline), Op]
        public static string format(byte src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex8) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        public static string format(uint src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex32) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        public static string format(ushort src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex16) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        public static string format(ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex64) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);
    }
}