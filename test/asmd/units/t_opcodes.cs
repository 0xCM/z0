//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static Konst;
    using static Memories;

    public class t_opcodes : t_asmd<t_opcodes>
    {

        void emit(ReadOnlySpan<InstructionExpression> src)
        {
            var dstPath = CasePath($"InstructionExpression");
            using var writer = dstPath.Writer();
            writer.WriteLine("Instruction");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        void emit(ReadOnlySpan<OpCodeIdentifier> src)
        {
            var dstPath = CasePath($"OpCodeIdentifiers");
            using var writer = dstPath.Writer();
            writer.WriteLine("Identifier");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }

        }

        void emit(ReadOnlySpan<OpCodeExpression> src)
        {
            var dstPath = CasePath($"OpCodes");
            using var writer = dstPath.Writer();
            writer.WriteLine("OpCode");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }

        }

        void emit(ReadOnlySpan<MnemonicExpression> src)
        {
            var dstPath = CasePath($"Mnemonics");
            using var writer = dstPath.Writer();
            writer.WriteLine("Mnemonic");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public void opcode_encode()
        {
            var encoder = OpCodeServices.encoder();
            var encoded = encoder.Encode();
            using var dst = CaseWriter("OpCodes.Encoded");
            for(var i=0; i<encoded.Length; i++)
            {
                dst.WriteLine(encoded[i]);
            }
        }

        public void opcode_reccords()
        {
            var tokens = OpCodeServices.tokens();
            for(var i=0; i<tokens.Length; i++)
            {
                Trace(tokens[i].Value);            
            }
            
            var data = OpCodeServices.dataset();
            var count = data.OpCodeCount;
            var records = data.Records.ToReadOnlySpan();
            using var writer = CaseWriter("OpCodes");
            
            writer.WriteLine(OpCodeRecord.FormatHeader());
            for(var i=0; i<records.Length; i++)
                writer.WriteLine(skip(records,i).Format());        
        }

        void opcode_tokens()
        {
            var data = OpCodeServices.dataset();
            var count = data.OpCodeCount;
            var records = data.Records.ToReadOnlySpan();
            var identifers = data.OpCodeIdentifiers.ToReadOnlySpan();
            Claim.eq(count, records.Length);
            Claim.eq(count, identifers.Length);

            var processor = OpCodePartitoner.Create();
            var handler = OpCodePartition.Create(count);
            processor.Partition(records, handler);

            emit(handler.Instructions);
            emit(handler.OpCodes);
            emit(handler.Mnemonics);
        }
    }
}
