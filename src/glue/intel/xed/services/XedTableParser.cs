//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static XedModels;
    using static XedRuleTable;

    using SQ = SymbolicQuery;
    using SP = SymbolicParse;


    [ApiHost]
    public class XedTableParser : AppService<XedTableParser>
    {
        Symbols<AttributeKind> Attributes;

        Symbols<Category> Categories;

        public XedTableParser()
        {
            Attributes = Symbols.index<AttributeKind>();
            Categories = Symbols.index<Category>();
        }

        [MethodImpl(Inline), Op]
        public static TableRow row(TableRowKind kind, AsciLine src)
            => new TableRow(kind,src);

        [MethodImpl(Inline), Op]
        static TableRowKind classify(in AsciLine src)
        {
            var data = src.Codes;
            if(data.Length < 2)
                return 0;

            ref readonly var c0 = ref skip(data,0);
            ref readonly var c1 = ref skip(data,1);
            if(SQ.hash(c0))
                return TableRowKind.Comment;

            if(SQ.digit(base10,c0))
                return TableRowKind.Instruction;
            else if(SQ.digit(base10,c1))
                return TableRowKind.OpCount;
            else if(SQ.tab(c0))
                return TableRowKind.Operand;
            else
                return 0;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(in AsciLine line, out TableRow dst)
        {
            dst = TableRow.Empty;
            var outcome = Outcome.Success;
            if(line.IsNonEmpty)
            {
                ref readonly var c = ref line[0];
                var kind = classify(line);
                if(kind == 0)
                    outcome = (false,"Row classification failed");
                else
                    dst = row(kind,line);
            }
            return outcome;
        }

        public ReadOnlySpan<XedRuleTable> Parse(FS.FilePath src)
        {
            using var reader = src.AsciLineReader();
            var buffer = alloc<XedRuleTable>(Pow2.T13);
            var dst = span(buffer);
            var outcome = Outcome.Success;
            var tables = 0u;
            while(reader.Next(out var line))
            {
                if(line.IsEmpty)
                    continue;

                ref readonly var c = ref line[0];
                if(SQ.hash(c))
                    continue;

                outcome = parse(line, out var row);
                if(outcome.Fail)
                {
                    Error(outcome.Message);
                    break;
                }

                var i=0u;
                ref var target = ref seek(dst,tables++);
                outcome = ParseDigits(line, ref i, out target.Instruction.Sequence);
                if(outcome.Fail)
                {
                    Error(outcome.Message);
                    break;
                }
            }
            return slice(dst, 0, tables);
        }

        /// <summary>
        /// Parsed the leading digit sequence of a given row
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        Outcome ParseDigits(in AsciLine src, ref uint i, out ushort dst)
        {
            var i0 = i;
            var result = Outcome.Success;
            dst = default;
            var data = slice(src.Codes, i);
            var length = data.Length;
            for(; i<length; i++)
            {
                ref readonly var c = ref skip(data,i);
                if(SQ.whitespace(c))
                    continue;

                if(SQ.digit(base10, c))
                {
                    result = SP.parse(base10, slice(data,i), out dst);
                    break;
                }
            }
            return result;
        }
    }

    /*
    '{Sequence} {IClass} {IForm} {Category} {Extension} {Isa} ATTRIBUTES: (Attributes)*'
    205 OR OR_MEMv_IMMb LOGICAL BASE I86 ATTRIBUTES: LOCKABLE SCALABLE
    3
        0 MEM0 | EXPLICIT | RW | IMM_CONST | INT
        1 IMM0 | EXPLICIT | R | IMM_CONST | I8
        2 REG0 | SUPPRESSED | W | NT_LOOKUP_FN | INVALID | RFLAGS

    */

}