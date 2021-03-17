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

    public class AsmStatementThumbprints
    {
        public AsmStatementThumbprints()
        {
            Lookup = new Dictionary<AsmThumbprint, AsmStatementThumbprint>();
            _Collected = Index<AsmStatementThumbprint>.Empty;
        }

        readonly Dictionary<AsmThumbprint,AsmStatementThumbprint> Lookup;

        Index<AsmStatementThumbprint> _Collected;

        public ReadOnlySpan<AsmStatementThumbprint> Collected()
        {
            if(_Collected.IsEmpty)
            {
                var collected = Lookup.Values.OrderBy(x => x.Thumbprint).Array();
                _Collected = collected;
            }
            return _Collected;
        }

        public uint Render(ITextBuffer dst)
            => AsmSyntax.render(this, dst);

        public bool IsFrozen
            => _Collected.IsNonEmpty;

        public string Format()
        {
            var dst = text.buffer();
            Render(dst);
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public void Add(AsmStatementThumbprint src)
        {
            if(!IsFrozen)
                Lookup.TryAdd(src.Thumbprint, src);
            else
                root.@throw("You are attempting to include data to a frozen collection");
        }
    }
}