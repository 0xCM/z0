//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost]
    public readonly partial struct CodeSolutions
    {
        [Op]
        public static ReadOnlySpan<string> SymbolKindNames()
            => SymbolKindText.Kinds;
    }
}