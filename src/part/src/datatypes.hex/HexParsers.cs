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
    public readonly struct HexParsers
    {
        [MethodImpl(Inline)]
        public static HexScalarParser scalar()
            => HexScalarParser.Service;

        [MethodImpl(Inline)]
        public static IHexParser<byte> bytes(bool bytes = true)
            => HexByteParser.Service;
    }
}