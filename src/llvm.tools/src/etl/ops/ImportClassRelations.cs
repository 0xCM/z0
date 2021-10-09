//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using static core;
    using static Root;

    using SQ = SymbolicQuery;

    partial class EtlWorkflow
    {
        ReadOnlySpan<ClassRelations> ImportClassRelations(ReadOnlySpan<TextLine> src)
        {
            const string Marker = "class ";
            var lines = list<TextLine>();
            var dst = list<ClassRelations>();
            var name = EmptyString;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = text.index(content, Marker);
                var isDefEnd = text.begins(content, Chars.RBrace);
                if(j >= 0)
                {
                    var k = text.index(content, Chars.LBrace);
                    if(k>=0)
                    {
                        var lt = text.index(content,Chars.Lt);
                        if(lt >=0)
                            name = text.trim(text.inside(content, j + Marker.Length - 1, lt));
                        else
                            name = text.trim(text.inside(content, j + Marker.Length - 1, k));

                        if(empty(name) || text.member(name, ClassExclusions))
                            continue;

                        var record = new ClassRelations();
                        record.SourceLine = line.LineNumber;
                        record.Name = name;
                        ancestors(content, out record.Ancestors);
                        dst.Add(record);
                    }
                }
            }

            var collected = dst.ViewDeposited();
            TableEmit(collected, ClassRelations.RenderWidths, LlvmPaths.ImportTable<ClassRelations>());
            return collected;
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