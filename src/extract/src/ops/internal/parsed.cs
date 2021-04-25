//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiExtracts
    {
        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<byte> parsed(in EncodingParser parser)
            => (parser.Offset + parser.Delta - 1) > 0 ? parser.Buffer.Slice(0, parser.Offset + parser.Delta - 1) : sys.empty<byte>();
    }
}