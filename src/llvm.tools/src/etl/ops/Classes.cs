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
        public ReadOnlySpan<ClassRecord> Classes(LlvmDatasetKind kind)
            => Classes(kind, x => true);

        ReadOnlySpan<ClassRecord> Classes(ReadOnlySpan<TextLine> src, LlvmDatasetKind kind, Func<ClassRecord,bool> filter)
        {
            const string Marker = "class ";
            var fields = list<RecordField>();
            var lines = list<TextLine>();
            var dst = list<ClassRecord>();
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
                        var record = new ClassRecord();
                        record.Dataset = kind;
                        record.Offset = line.LineNumber;
                        var lt = text.index(content,Chars.Lt);
                        if(lt >=0)
                            record.Name = text.trim(text.between(content, j + Marker.Length - 1, lt));
                        else
                        {
                            record.Name = text.trim(text.between(content, j + Marker.Length - 1, k));
                        }
                        var m = SQ.index(content, Chars.FSlash, Chars.FSlash);
                        if(m >= 0)
                            record.Ancestors = text.trim(text.right(content, m + 1));
                        if(filter(record))
                            dst.Add(record);
                    }
                }
            }

            var results = dst.ToArray();
            return results;
        }

   }
}