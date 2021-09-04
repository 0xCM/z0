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

    using SQ = SymbolicQuery;

    [ApiHost]
    public readonly partial struct SdmRecords
    {
        static string ocnormal(string src)
        {
            return
                src.Replace("+ rb", " +rb")
                    .Replace("+ rw", " +rw")
                    .Replace("+ rd", " +rd")
                    .Replace("+ ro", " +ro")
                    .Replace("/ r", "/r")
                    .Trim()
                    ;
        }

        static string opnormal(string src)
            => src switch {
                "r32a" => "r32",
                "r32b" => "r32",
                "r64a" => "r64",
                "r64b" => "r64",
                "mm1" => "mm",
                "mm2" => "mm",
                "mm2/m64" => "mm/m64",
                "xmm1" => "xmm",
                "xmm2" => "xmm",
                "xmm3" => "xmm",
                "xmm2/m128" => "xmm/m128",
                "ymm1" => "ymm",
                "ymm2" => "ymm",
                "ymm2/m256" => "ymm/m256",
                "zmm1" => "zmm",
                "zmm2" => "zmm",
                _ => src
            };

        static string operands(string sig)
        {
            static ReadOnlySpan<string> _operands(string src)
                => text.split(src, Chars.Comma).Select(op => opnormal(op.Trim()));

            var i = SQ.index(sig, Chars.Space);
            if(i > 0)
                return text.join(", ", _operands(text.format(SQ.right(sig,i))));
            else
                return EmptyString;
        }

        [Op]
        public static uint fill(Table src, Span<SdmOpCodeDetail> dst)
        {
            var counter = 0u;
            var rows = src.Rows;
            var count = rows.Length;
            var cols = src.Cols;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(rows,i);
                var target = new SdmOpCodeDetail();
                var cells = input.Cells;
                var valid = true;

                for(var k=0; k<cells.Length; k++)
                {
                    ref readonly var col = ref skip(cols,k);
                    ref readonly var cell = ref skip(cells,k);
                    var content = text.format(cell.Content).Trim();
                    switch(col.Name)
                    {
                        case "Opcode":
                        var oc = ocnormal(content);
                        target.OpCode = oc;
                        if(empty(oc))
                            valid = false;
                        break;

                        case "Instruction":
                            var monic = text.trim(text.ifempty(text.left(content, Chars.Space), content));
                            //target.Sig = content;
                            var ops = operands(content);
                            if(nonempty(ops))
                                target.Sig = string.Format("{0} {1}", monic, ops);
                            else
                                target.Sig = monic;
                            target.Mnemonic = monic;
                            if(empty(monic))
                                valid = false;
                        break;

                        case "Op / En":
                        case "Op/En":
                            target.EncXRef = content;
                        break;

                        case "Compat/Leg Mode":
                            target.LegacyMode = content;
                        break;

                        case "64-bit Mode":
                            target.Mode64 = content;
                        break;

                        case "64/32 bit Mode Support":
                            target.Mode64x32 = content;
                        break;

                        case "CPUID Feature Flag":
                            target.CpuId = content;
                        break;

                        case "Description":
                            target.Description = content;
                        break;
                    }
                }

                if(valid)
                    seek(dst,counter++) = target;
            }
            return counter;
        }
    }
}