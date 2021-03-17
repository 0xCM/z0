//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly struct AsmSourceDocs
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline), Op]
        public static AsmCodeSyntax line(GridPoint<uint> location, dynamic content)
            => new AsmCodeSyntax(location, content);
    }
}