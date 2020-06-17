//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static Memories;

    public class t_tokens : t_asmd<t_tokens>
    {
        void emit(ReadOnlySpan<InstructionExpression> src)
        {
            var dstPath = CasePath($"InstructionExpression");
            using var writer = dstPath.Writer();
            writer.WriteLine("Instruction");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Body.MaxLength));
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
                writer.WriteLine(id.Format().PadRight(id.Body.MaxLength));
            }

        }

        void emit(ReadOnlySpan<AsmCommandGroup> src)
        {
            var dstPath = CasePath($"AsmCommandGroup");
            using var writer = dstPath.Writer();
            writer.WriteLine("Mnemonic");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Body.MaxLength));
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
                writer.WriteLine(id.Format().PadRight(id.Body.MaxLength));
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
                writer.WriteLine(id.Format().PadRight(id.Body.MaxLength));
            }

        }

        public void opcode_tokens()
        {
            var data = OpCodeDataset.Create();
            var count = data.OpCodeCount;
            var records = data.OpCodeRecords.ToReadOnlySpan();
            var identifers = data.OpCodeIdentifiers.ToReadOnlySpan();
            Claim.eq(count, records.Length);
            Claim.eq(count, identifers.Length);


            var processor = OpCodeProcessor.Create();
            var handler = OpCodeHandler.Create(count);
            processor.Process(records,handler);


            emit(handler.Instructions);
            emit(handler.OpCodes);
            emit(handler.Mnemonics);

        }
        
        public void opcode_resource_doc()
        {
            const char TextDelimiter = Chars.Pipe;
            var svc = AsmD.Service;
            var count1 = svc.OpCodeSpecDoc.CharCount(TextDelimiter);
            var count2 = Symbolic.count(svc.OpCodeSpecText, 1, TextDelimiter);
            Claim.eq(count1,count2);
        }

        string Format<S>(Symbol<S> symbol)
            where S : unmanaged, Enum
        {
            return symbol.Value.ToString();
        }
        public void symbolic_digits()
        {
            var symbols = octet.Symbols;
            var dstPath = CasePath($"octets");
            using var writer = dstPath.Writer();
            for(var i=0; i<symbols.Count; i++)
            {
                ref readonly var s = ref symbols[i];
                writer.WriteLine(Format(s.Simplified));
            }            
           
        }
    }
}