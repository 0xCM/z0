//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmExpr;
    using static z;

    public class t_opcodes : t_asmd<t_opcodes>
    {
        void emit(ReadOnlySpan<AsmExpr.Signature> src)
        {
            var dstPath = CasePath($"InstructionExpression");
            using var writer = dstPath.Writer();
            writer.WriteLine("Instruction");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(32));
            }
        }

        void emit(ReadOnlySpan<AsmOpCodeExprLegacy> src)
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

        // void emit(ReadOnlySpan<AsmOpCodeExpression> src)
        // {
        //     var dstPath = CasePath($"OpCodes");
        //     using var writer = dstPath.Writer();
        //     writer.WriteLine("OpCode");
        //     for(var i=0; i<src.Length; i++)
        //     {
        //         ref readonly var id = ref skip(src,i);
        //         writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
        //     }

        // }

        // void emit(ReadOnlySpan<AsmMnemonicExpr> src)
        // {
        //     var dstPath = CasePath($"Mnemonics");
        //     using var writer = dstPath.Writer();
        //     writer.WriteLine("Mnemonic");
        //     for(var i=0; i<src.Length; i++)
        //     {
        //         ref readonly var id = ref skip(src,i);
        //         writer.WriteLine(id.Format().PadRight(id.Content.Capacity));
        //     }
        // }


        // public void check_opcode_records()
        // {
        //     var data = AsmOpCodesLegacy.dataset();
        //     var count = data.OpCodeCount;
        //     var records = data.Entries.View;
        //     var formatter = Records.formatter<AsmOpCodeRowLegacy>();
        //     using var writer = CaseWriter("OpCodes");
        //     writer.WriteLine(formatter.FormatHeader());
        //     for(var i=0; i<records.Length; i++)
        //         writer.WriteLine(formatter.Format(skip(records,i)));
        // }
    }
}