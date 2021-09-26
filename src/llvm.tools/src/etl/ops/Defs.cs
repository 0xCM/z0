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
        public static bool DefinesInstruction(DefRecord src)
        {
            bit result = 1;
            result &= Enums.parse(src.Name, out AsmId dst);
            result &= (src.Ancestors.StartsWith("InstructionEncoding"));
            return result;
        }

        ReadOnlySpan<DefRecord> Defs(ReadOnlySpan<TextLine> src)
        {
            const string Marker = "def ";
            var fields = list<RecordField>();
            var lines = list<TextLine>();
            var dst = list<DefRecord>();
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
                        var record = new DefRecord();
                        record.Offset = line.LineNumber;
                        record.Name = text.trim(text.inside(content, j + Marker.Length - 1, k));
                        var m = SQ.index(content, Chars.FSlash, Chars.FSlash);
                        if(m >= 0)
                            record.Ancestors = text.trim(text.right(content, m + 1));
                        dst.Add(record);
                    }
                }
            }

            var results = dst.ViewDeposited();
            return results;
        }
    }
}