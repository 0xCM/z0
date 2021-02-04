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
    public readonly struct ByteSpans
    {
        [MethodImpl(Inline), Op]
        public static string property(CodeBlock src, ApiArtifactKey uri)
            => comment(new ByteSpanProperty(uri.Identifier, src).Format());

        [MethodImpl(Inline), Op]
        public static string property(CodeBlock src, OpIdentity id)
            => comment(new ByteSpanProperty(LegalIdentityBuilder.code(id), src).Format());

        [MethodImpl(Inline), Op]
        public static string comment(string text)
            =>  $"; {text}";
    }
}