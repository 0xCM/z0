//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    partial struct ApiExtracts
    {
        [MethodImpl(Inline), Op]
        internal static EncodingParser encodings(byte[] buffer)
            => new EncodingParser(EncodingPatterns.Default, buffer);
    }
}
