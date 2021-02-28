//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct SmallHex
    {
        [MethodImpl(Inline), Op]
        public static string format(byte src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex8Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        public static string format(uint src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex32Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        public static string format(ushort src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex16Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        public static string format(ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex64Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);
    }
}