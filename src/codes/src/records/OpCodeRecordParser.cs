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
        public Span<OpCodeRecord> Parse(AppResourceDoc specs)
        {
            var src = specs.DataRows;
            var dst = Spans.alloc<OpCodeRecord>(src.Length);
            for(var i=0; i<src.Length; i++)
               Parse(skip(src,i), ref seek(dst,i));            
            return dst;
        }

        ref readonly OpCodeRecord Parse(string src, ref OpCodeRecord dst)
        {            
            ReadOnlySpan<string> fields = src.SplitClean(Chars.Pipe);

            var parser = AsmFieldParser.Service;            
            for(var i=0; i<fields.Length; i++)
            {   
                ref readonly var field = ref skip(fields,i);
                switch((F)i)
                {
                    case F.Sequence:
                        parser.Parse(field, out dst.Seq);
                        break;                    
                    case F.Mnemonic:
                        parser.Parse(field, out dst.Mnemonic);
                        break;     
                    case F.Expression:
                        parser.Parse(field, out dst.Expression);
                        break;                    
                    case F.Instruction:
                        parser.Parse(field, out dst.Instruction);
                        break;                    
                    case F.M16:
                        parser.Parse(field, out dst.M16);
                        break;                    
                    case F.M32:
                        parser.Parse(field, out dst.M32);
                        break;                    
                    case F.M64:
                        parser.Parse(field, out dst.M64);
                        break;                    
                    case F.CpuId:
                        parser.Parse(field, out dst.CpuId);
                        break;                    
                    case F.Id:
                        parser.Parse(field, out dst.Id);
                        break;                                                       
                }
            }

            return ref dst;
        } 
    }
}