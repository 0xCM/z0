//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class HexParser
    {
        public static HexNumberParser Default
        {
            [MethodImpl(Inline)]
            get => HexNumberParser.Default;
        }

        public static HexByteParser ByteParser
        {
            [MethodImpl(Inline)]
            get => HexByteParser.Default;
        }
    }
}
