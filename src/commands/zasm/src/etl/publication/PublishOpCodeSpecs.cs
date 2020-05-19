//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm.Data;

    using static Seed;

    using F = OpCodeSpecField;

    partial class AsmEtl
    {                
        public OpCodeSpec[] GatherOpCodeSpecs()
        {
            var delimiter = Chars.Pipe;
            var specs = OpCodeInfoParser.ParseOpCodeInfo(Config.OpCodeInfoPath);
            var sorted = (from item in specs
                          let id = item.Id.ToString()
                          orderby id
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
                    Modes: src.Modes, 
                    CpuId: src.CpuId
                    );
            }
            return dst;
        }

        public OpCodeSpec[] PublishOpCodeSpecs()
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
                sb.AppendField(F.Modes, spec.Modes, delimiter);
                sb.AppendField(F.CpuId,  spec.CpuId, delimiter);
                sb.AppendField(F.Id, spec.Id, delimiter);
                writer.WriteLine(sb.ToString());                
            }                    
            return specs;
       }
    }
}