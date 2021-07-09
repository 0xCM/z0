//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static XedModels;

    using SQ = SymbolicQuery;
    using SP = SymbolicParse;


    public ref struct XedTableParser
    {
        public static XedTableParser create(IntelXed xed)
            => new XedTableParser(xed);

        IntelXed Xed;

        Symbols<AttributeKind> Attributes;

        Symbols<Category> Categories;

        public XedTableParser(IntelXed xed)
        {
            Xed = xed;
            Attributes = xed.AttributeKinds();
            Categories = xed.Categories();
        }

        public void Parse(FS.FilePath src)
        {
            using var reader = AsciLineReader.open(src);
            var buffer = alloc<XedRuleTable>(Pow2.T13);
            var dst = span(buffer);
            var outcome = Outcome.Success;
            var tables = 0u;
            while(reader.Next(out var line))
            {
                if(line.IsEmpty)
                    continue;

                var data = line.Codes;
                for(var i=0; i<data.Length; i++)
                {
                    ref readonly var c = ref skip(data,i);
                    if(SQ.hash(c))
                        break;
                }

                outcome = Parse(reader, ref seek(dst, tables++));
                if(outcome.Fail)
                {
                    break;
                }
            }
        }

        Outcome Parse(AsciLineReader src, ref XedRuleTable dst)
        {
            var result = Outcome.Success;
            while(src.Next(out var line))
            {
                if(line.IsEmpty)
                    continue;

                var data = line.Codes;
                var length = data.Length;
                var digits = SQ.digits(n16, base10, data);
                if(digits.Length == 0)
                    result = (false,"No digits found");
                else
                {
                    SP.parse(base10, digits, out dst.Header.Sequence);
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