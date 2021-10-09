//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using static core;

    using SQ = SymbolicQuery;

    public abstract class RelationDistiller<T>
        where T : struct
    {
        Dictionary<string,Lineage> Nodes;

        public abstract ReadOnlySpan<T> DistillRelations(ReadOnlySpan<TextLine> src);

        protected HashSet<string> ClassExclusions {get;}
            = hashset<string>("Hexagon", "Neon", "PowerPC", "RISCV", "SystemZ", "Hexagom", "AMDGPU");

        protected RelationDistiller()
        {
            Nodes = new();
        }

        protected bool GetAncestors(string content, out Lineage dst)
        {
            var m = SQ.index(content, Chars.FSlash, Chars.FSlash);
            if(m >= 0)
            {
                var chain = text.trim(text.right(content, m + 1)).Split(Chars.Space);

                if(chain.Length > 0)
                {
                    dst = Lineage.path(chain);
                    return true;
                }
            }
            dst = Lineage.Empty;
            return false;
        }
    }
}