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
        public static AsmFragment<T> line<T>(GridPoint<uint> location, T content)
            where T : IAsmSyntaxPart<T>
                => new AsmFragment<T>(location, content);
    }
}