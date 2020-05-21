//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Linq;

    using static Seed;
    
    using M = AsmDataModels;
    using F = OpCodeSpecField;

    partial class AsmEtl
    {                
        public OpCodeSpec[] GatherOpCodeSpecs()
        {
            var delimiter = Chars.Pipe;
            var specs = OpCodeInfoParser.ParseOpCodeInfo(Config.OpCodeInfoPath);
            var sorted = (from item in specs                          
                          orderby item.OrderBy
                          select item).ToArray();
            
            var dst = Control.alloc<OpCodeSpec>(sorted.Length);
            for(var i=0; i<sorted.Length; i++)
            {
                var src = sorted[i];
                dst[i] = new OpCodeSpec(
                    Sequence: i, 
                    Id: (OpCodeId)src.Id, 
                    Mnemonic: src.Mnemonic, 
                    Instruction: src.Instruction, 
                    Expression: src.Expression, 
                    M16: src.Mode16 ? YeaOrNea.Y : YeaOrNea.N,
                    M32: src.Mode32 ? YeaOrNea.Y : YeaOrNea.N,
                    M64: src.Mode64 ? YeaOrNea.Y : YeaOrNea.N,
                    CpuId: src.CpuId
                    );
            }
            return dst;
        }

        public OpCodeSpec[] Publish(M.OpCodeSpecs model)
        {
            var delimiter = Chars.Pipe;
            var specs = GatherOpCodeSpecs();

            var dst = Config.DatasetPath("OpCodeSpecs");
            var sb = text.build();
            
            using var writer = dst.Writer();            
            sb.AppendHeader<F>(delimiter);
            writer.WriteLine(sb.ToString());
        
            for(var i=0; i<specs.Length; i++)
            {
                sb.Clear();             
                var spec = specs[i];
                sb.AppendField(F.Sequence, i);
                sb.AppendField(F.Mnemonic, spec.Mnemonic, delimiter);
                sb.AppendField(F.Expression, spec.Expression, delimiter);
                sb.AppendField(F.Instruction, spec.Instruction, delimiter);
                sb.AppendField(F.M16, spec.M16, delimiter);
                sb.AppendField(F.M32, spec.M32, delimiter);
                sb.AppendField(F.M64, spec.M64, delimiter);
                sb.AppendField(F.CpuId,  spec.CpuId, delimiter);
                sb.AppendField(F.Id, spec.Id, delimiter);
                writer.WriteLine(sb.ToString());                
            }                    
            return specs;
        }        
    }
}