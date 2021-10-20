//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using SQ = SymbolicQuery;

    partial class EtlWorkflow
    {
        ReadOnlySpan<T> DistillRelations<T>(ReadOnlySpan<TextLine> src, string marker)
            where T : struct, ILineRelations<T>
        {
            var dst = list<T>();
            var name = EmptyString;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = text.index(content, marker);
                if(j >= 0)
                {
                    var k = text.index(content, Chars.LBrace);
                    if(k>=0)
                    {
                        var record = new T();
                        name = text.trim(text.inside(content, j + marker.Length - 1, k));
                        if(empty(name) || text.member(name, ClassExclusions))
                            continue;

                        ancestors(content, out var a);
                        record.Specify(line.LineNumber, name, a);
                        dst.Add(record);
                    }
                }
            }
            return dst.ViewDeposited();
        }

        static bool ancestors(string content, out Lineage dst)
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