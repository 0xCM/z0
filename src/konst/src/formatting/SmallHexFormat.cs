//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SmallHexFormat
    {
        [MethodImpl(Inline)]
        public static string format(ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.SmallHexSpec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline)]
        public static string format(byte src, bool postspec = false)
            => format(((ulong)src), postspec);

        [MethodImpl(Inline)]
        public static string format(uint src, bool postspec = false)
            => format(((ulong)src), postspec);

        [MethodImpl(Inline)]
        public static string format(ushort src, bool postspec = false)
            => format(((ulong)src), postspec);
    }
}