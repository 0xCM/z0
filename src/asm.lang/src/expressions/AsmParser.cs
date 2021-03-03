//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static TextRules;

    public sealed class AsmParser : WfService<AsmParser>
    {
        public Outcome ParseStatement(in TextLine src, out AsmStatementLine dst)
        {
            dst = AsmStatementLine.Empty;

            return false;
        }

        public Outcome ParseCode(string src, out AsmCodeDoc dst)
        {
            dst = AsmCodeDoc.Empty;
            var lines = Parse.lines(src).View;
            var count = lines.Length;
            var statments = alloc<AsmStatementLine>(count);
            ref var target = ref first(statments);
            for(var i=0u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                if(ParseStatement(line, out var statement))
                {
                    seek(target,i) = statement;
                }

                //seek(target,i) = new AsmCodeLine(i, skip(source, i).Content);
            }
            return false;
        }

    }
}