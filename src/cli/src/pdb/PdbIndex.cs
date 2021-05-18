//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;
    using static PdbModel;

    public sealed class PdbIndex : GlobalService<PdbIndex,PdbDataStore>
    {
        public uint Include(ReadOnlySpan<Document> src)
            => State.Include(src);

        protected override PdbIndex Init(out PdbDataStore state)
        {
            state = new();
            return this;
        }

        public ReadOnlySpan<Document> Documents
            => State.Documents;
    }
}