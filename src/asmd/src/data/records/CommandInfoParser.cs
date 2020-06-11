//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using F = CommandInfoField;

    [ApiHost]
    public readonly struct OpCodeRecordParser : IApiHost<OpCodeRecordParser>
    {
        public static OpCodeRecordParser Service => default;

        [Op, MethodImpl(Inline)]
        public void Parse(in AppResourceDoc specs, Span<CommandInfo> dst)
        {
            var src = specs.Rows.ToReadOnlySpan();
            var count = src.Length;
            for(var i=0; i<count; i++)
               Parse(skip(src,i), ref seek(dst,i));            
        }

        public Span<CommandInfo> Parse(in AppResourceDoc specs)
        {
            var src = specs.Rows;
            var count = src.Length;
            var dst = Spans.alloc<CommandInfo>(count);
            Parse(specs,dst);
            return dst;
        }

        [Op]
        ref readonly CommandInfo Parse(in TextRow src, ref CommandInfo dst)
        {                        
            ReadOnlySpan<string> cells = src.CellContent;

            var parser = AsmFieldParser.Service;            
            for(var i=0; i<cells.Length; i++)
            {   
                ref readonly var cell = ref skip(cells,i);
                switch((F)(byte)i)
                {
                    case F.Sequence:
                        parser.Parse(cell, out dst.Seq);
                        break;                    
                    case F.GlobalOffset:
                        parser.Parse(cell, out dst.GlobalOfset);
                        break;                    
                    case F.LocalOffset:
                        parser.Parse(cell, out dst.LocalOffset);
                        break;                    
                    case F.Mnemonic:
                        parser.Parse(cell, out dst.Mnemonic);
                        break;     
                    case F.OpCode:
                        parser.Parse(cell, out dst.OpCode);
                        break;                    
                    case F.Encoded:
                        parser.Parse(cell, out dst.Encoded);
                        break;                    
                    case F.InstructionFormat:
                        parser.Parse(cell, out dst.InstructionFormat);
                        break;                    
                    case F.InstructionCode:
                        parser.Parse(cell, out dst.InstructionCode);
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