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

    using F = OpCodeFieldId;

    public readonly struct OpCodeRecordParser
    {
        public static OpCodeRecordParser Service => default;

        [Op, MethodImpl(Inline)]
        public Span<OpCodeRecord> Parse(in AppResourceDoc specs)
        {
            var src = specs.Rows;
            var count = src.Length;
            var dst = Spans.alloc<OpCodeRecord>(count);
            for(var i=0; i<count; i++)
               Parse(skip(src,i), ref seek(dst,i));            
            return dst;
        }

        ref readonly OpCodeRecord Parse(in TextRow src, ref OpCodeRecord dst)
        {                        
            ReadOnlySpan<string> cells = src.CellContent;

            var parser = AsmFieldParser.Service;            
            for(var i=0; i<cells.Length; i++)
            {   
                ref readonly var cell = ref skip(cells,i);
                switch((F)i)
                {
                    case F.Sequence:
                        parser.Parse(cell, out dst.Seq);
                        break;                    
                    case F.Mnemonic:
                        parser.Parse(cell, out dst.Mnemonic);
                        break;     
                    case F.Expression:
                        parser.Parse(cell, out dst.Expression);
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
                    case F.Id:
                        parser.Parse(cell, out dst.Id);
                        break;                                                       
                }
            }

            return ref dst;
        } 
    }
}