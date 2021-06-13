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
        public static SyntaxFragment<T> line<T>(GridPoint<uint> location, T content)
            where T : ISyntaxPart<T>
                => new SyntaxFragment<T>(location, content);
    }
}