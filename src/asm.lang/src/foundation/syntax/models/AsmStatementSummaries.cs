//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    public class AsmStatementSummaries
    {
        public AsmStatementSummaries()
        {
            Lookup = new Dictionary<AsmThumbprintExpr, AsmStatementSummary>();
            _Collected = Index<AsmStatementSummary>.Empty;
        }

        readonly Dictionary<AsmThumbprintExpr,AsmStatementSummary> Lookup;

        Index<AsmStatementSummary> _Collected;

        public ReadOnlySpan<AsmStatementSummary> Collected()
        {
            if(_Collected.IsEmpty)
            {
                var collected = Lookup.Values.OrderBy(x => x.Thumbprint).Array();
                _Collected = collected;
            }
            return _Collected;
        }

        public bool IsFrozen
            => _Collected.IsNonEmpty;

        public void Add(AsmStatementSummary src)
        {
            if(!IsFrozen)
                Lookup.TryAdd(src.Thumbprint, src);
            else
                root.@throw("You are attempting to include data to a frozen collection");
        }
    }
}