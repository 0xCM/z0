//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static memory;
    using static Part;

    partial struct XedWfOps
    {
        const string RuleFormatPattern = "{0,-80} | {1, -12} | {2}";

        const string RulePageBreak = RP.PageBreak120;

        public static void emit(ReadOnlySpan<XedInstructionDoc> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                var rows = src[i];
                for(var j = 0; j < rows.RowCount; j++)
                    writer.WriteLine(rows[j].Text);
                if(i != src.Length - 1)
                    writer.WriteLine(RP.PageBreak120);
            }
        }

        public static void emit(ReadOnlySpan<XedRuleSet> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            emit(src, writer);
        }

        public static void emit(ReadOnlySpan<XedRuleSet> src, StreamWriter writer)
        {
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                var body = f.Terms;
                if(body.Length != 0)
                {
                    writer.WriteLine(f.Description);
                    writer.WriteLine(RP.PageBreak120);

                    for(var j = 0; j < body.Length; j++)
                        writer.WriteLine(body[j]);

                    if(i != src.Length - 1)
                        writer.WriteLine();
                }
            }
        }

        public static void emit(in XedRuleSet ruleset, StreamWriter writer)
        {
            var content = @readonly(ruleset.Terms);
            var kTerms = content.Length;
            if(kTerms != 0)
            {
                writer.WriteLine(ruleset.Description);
                writer.WriteLine(RulePageBreak);
                writer.WriteLine(text.format(RuleFormatPattern, "Source", "Operator", "Target"));
                for(var k=0; k<kTerms; k++)
                {
                    var line = skip(content,k).Format();
                    if(line.Contains('|'))
                    {
                        var parts = line.SplitClean('|');
                        if(parts.Length == 2)
                            writer.WriteLine(text.format(RuleFormatPattern, parts[0], ":=", parts[1]));

                    }
                    else if(line.Contains("->"))
                    {
                        var parts = line.SplitClean("->");
                        if(parts.Length == 2)
                            writer.WriteLine(text.format(RuleFormatPattern, parts[0], "->", parts[1]));
                    }
                    else
                        writer.WriteLine(line);
                }
                writer.WriteLine(RP.PageBreak120);
            }
        }

    }
}