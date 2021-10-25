//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using records;

    using static core;
    using static Root;

    public sealed class DefRelationDistiller : RelationDistiller<DefRelations>
    {
        public override ReadOnlySpan<DefRelations> DistillRelations(ReadOnlySpan<TextLine> src)
        {
            const string Marker = "def ";

            var dst = list<DefRelations>();
            var name = EmptyString;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = text.index(content, Marker);
                if(j >= 0)
                {
                    var k = text.index(content, Chars.LBrace);
                    if(k>=0)
                    {
                        var record = new DefRelations();
                        name = text.trim(text.inside(content, j + Marker.Length - 1, k));
                        if(empty(name) || text.member(name, ClassExclusions))
                            continue;

                        record.Name = name;
                        record.SourceLine = line.LineNumber;
                        GetAncestors(content, out record.Ancestors);
                        dst.Add(record);
                    }
                }
            }
            return dst.ViewDeposited();
        }
    }
}