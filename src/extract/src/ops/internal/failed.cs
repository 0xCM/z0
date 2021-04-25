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
        internal static bool failed(EncodingParserState state)
            => state == EncodingParserState.Failed;
    }
}