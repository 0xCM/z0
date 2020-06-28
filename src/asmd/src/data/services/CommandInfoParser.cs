//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    using F = OpCodeInfoField;

    [ApiHost]
    public readonly struct CommandInfoParser : IApiHost<CommandInfoParser>
    {
        public static CommandInfoParser Service 
            => default;

        [Op, MethodImpl(Inline)]
        public void Parse(in AppResourceDoc specs, Span<OpCodeRecord> dst)
        {
            var fields = Enums.literals<F>();
            var src = span(specs.Rows);
            for(var i=0; i<src.Length; i++)
               Parse(skip(src,i), fields, ref seek(dst,i));            
        }

        public Span<OpCodeRecord> Parse(in AppResourceDoc specs)
        {
            var dst = Spans.alloc<OpCodeRecord>(specs.Rows.Length);
            Parse(specs, dst);
            return dst;
        }

        [Op]
        ref readonly OpCodeRecord Parse(in TextRow src, ReadOnlySpan<F> fields, ref OpCodeRecord dst)
        {                        
            ReadOnlySpan<string> cells = src.CellContent;
            var count = length(cells,fields);

            var parser = AsmParsers.fields();
            for(var i=0; i<count; i++)
            {   
                ref readonly var cell = ref skip(cells,i);
                ref readonly var field = ref skip(fields,i);
                switch(field)
                {
                    case F.Sequence:
                        parser.Parse(cell, out dst.Sequence);
                        break;                    
                    case F.Mnemonic:
                        parser.Parse(cell, out dst.Mnemonic);
                        break;     
                    case F.OpCode:
                        parser.Parse(cell, out dst.OpCode);
                        break;        
                    case F.Instruction:
                        parser.Parse(cell, out dst.Instruction);
                        break;        
                    case F.M16:
                        parser.Parse(cell, out dst.M16);
                        break;        
                    case F.M32:
                        parser.Parse(cell, out dst.M32);
                        break;        
                    case F.M64:
                        parser.Parse(cell, out dst.M64);
                        break;        
                    case F.CpuId:
                        parser.Parse(cell, out dst.CpuId);
                        break;                    
                    case F.CodeId:
                        parser.Parse(cell, out dst.CodeId);
                        break;                                                       
                }
            }

            return ref dst;
        } 
    }
}