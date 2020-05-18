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

    using I = OpCodeSpecFieldId;
    using W = OpCodeSpecFieldWidth;
    using F = OpCodeSpecField;

    public enum OpCodeSpecFieldId
    {
        Mnemonic, Expression, Instruction, Modes, CpuId, OpCodeId,
    }

    public enum OpCodeSpecFieldWidth
    {
        Mnemonic = 16, Expression = 30, Instruction = 40, Modes = 16, 
        
        CpuId = 10,  OpCodeId = 10,

        Offset = 16
    }

    public enum OpCodeSpecField
    {
        Mnemonic = I.Mnemonic | (W.Mnemonic << W.Offset), 
        
        Expression = I.Expression | (W.Expression << W.Offset),  
        
        Instruction = I.Instruction | (W.Instruction << W.Offset), 
        
        Modes = I.Modes | (W.Modes << W.Offset),  
        
        CpuId = I.CpuId | (W.CpuId << W.Offset), 
        
        OpCodeId = I.OpCodeId | (W.OpCodeId << W.Offset), 
    }

    partial class AsmEtl
    {                
        public void PublishOpCodeInfo()
        {
            var delimiter = Chars.Pipe;
            var specs = OpCodeInfoParser.ParseOpCodeInfo(Config.OpCodeInfoPath);
            var sorted = (from item in specs
                         orderby item.Mnemonic
                         select item).ToArray();

            var dst = Config.DatasetPath("OpCodeInfo");
            var sb = text.build();
            
            using var writer = dst.Writer();            
            sb.AppendHeader<F>(delimiter);
            writer.WriteLine(sb.ToString());
        

            for(var i=0; i<sorted.Length; i++)
            {
                sb.Clear();
             
                var spec = sorted[i];
                sb.AppendField(F.Mnemonic, spec.Mnemonic);
                sb.AppendField(F.Expression, spec.Expression, delimiter);
                sb.AppendField(F.Instruction, spec.Instruction, delimiter);
                sb.AppendField(F.Modes, spec.Modes, delimiter);
                sb.AppendField(F.CpuId,  spec.CpuId, delimiter);
                sb.AppendField(F.OpCodeId, spec.Id, delimiter);
                writer.WriteLine(sb.ToString());                
            }                    
       }
    }
}