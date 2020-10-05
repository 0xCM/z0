//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ByteSpans
    {
        [MethodImpl(Inline), Op]
        public static string property(BasedCodeBlock src, ApiMetadataUri uri)
            => comment(new ByteSpanProperty(uri.Identifier, src).Format());

        [MethodImpl(Inline), Op]
        public static string comment(string text)
            =>  $"; {text}";

    }
}
