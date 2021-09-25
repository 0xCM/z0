//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct QueryMatch
    {
        public Query Query {get;}

        public uint Id {get;}

        public string Matched {get;}

        [MethodImpl(Inline)]
        public QueryMatch(Query query, uint id, string content)
        {
            Query = query;
            Id = id;
            Matched = content;
        }
    }
}