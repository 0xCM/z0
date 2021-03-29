//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmThumprintCatalog
    {
        readonly Index<Paired<AsmStatementExpr, AsmThumbprint>> _Entries;

        [MethodImpl(Inline)]
        public AsmThumprintCatalog(Index<Paired<AsmStatementExpr, AsmThumbprint>> entries)
        {
            _Entries = entries;
        }

        public ReadOnlySpan<Paired<AsmStatementExpr, AsmThumbprint>> Entries
        {
            [MethodImpl(Inline)]
            get => _Entries.View;
        }
    }
}