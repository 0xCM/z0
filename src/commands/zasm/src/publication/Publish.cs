//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using LL = Asm.Data.LiteralLookups;
    using M = AsmDataModels;

    using static Seed;
    using static AsmDataModels;
    using static Memories;

    partial class AsmEtl
    {        
        OperandCountRecord[] Publish(OperandCounts model)
        {
            var dp = DataPublisher.Service;
            
            var counts = InstructionOpCounts.OpCount;
            var codes = Enums.literals<OpCodeId>();
            insist(counts.Length, codes.Length);
    
            var dst = Control.alloc<OperandCountRecord>(counts.Length);
            for(var i=0; i < counts.Length; i++)
            {
                var code = codes[i];
                insist(code.Index, i);

                dst[i] = new OperandCountRecord(i, counts[i], code.Value);
            }

            dp.Save(model, OperandCountField.Sequence, dst, Chars.Pipe);
            return dst;
        }

        public void Publish()
        {
            var specs = Publish(M.OpCodeSpecs.Model);
            var index = OpCodeSpecs.From(specs);
            var tests =Publish(M.DecoderTests.Model, index).Force();        
            var forms = Publish(AsmEtl.OpCodeForms, index);

            LiteralPublisher.Service.Publish();            

            var dp = DataPublisher.Service;
            dp.PublishList<Mnemonic>();
            dp.PublishList(LL.Codes, nameof(LL.Codes));
            dp.PublishList(LL.MemorySizes, nameof(LL.MemorySizes));
            dp.PublishList(LL.Registers, nameof(LL.Registers));

            Publish(OperandCounts.Model);

                        
            Publish(AsmEtl.Instructions);
        }
    }
}