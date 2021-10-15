//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class IntelSdm
    {
        public ReadOnlySpan<Table> ReadSourceTables()
        {
            var src = Ws.Sources().Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var svc = Wf.IntelSdm();
            return svc.ReadCsvTables(src);
        }

        public Index<AsmForm> EmitForms(ReadOnlySpan<SdmOpCodeDetail> opcodes)
        {
            const string Pattern = "{0,-16} | {1,-64} | {2}";
            const string OpSep = ", ";
            var dst = Project().Subdir("imports") + FS.file("asm.forms", FS.Csv);
            using var writer = dst.UnicodeWriter();
            var _forms = asm.forms(opcodes);
            var count = _forms.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var form = ref _forms[i];
                ref readonly var sig = ref form.Sig;
                var operands = EmptyString;
                var opcount = form.Sig.OperandCount;
                switch(opcount)
                {
                    case 1:
                        operands = AsmSigs.operand(sig,0).Format();
                    break;
                    case 2:
                        operands = string.Format(RP.delimit(n2, OpSep),
                            AsmSigs.operand(sig,0),
                            AsmSigs.operand(sig,1)
                            );
                    break;
                    case 3:
                        operands = string.Format(RP.delimit(n3, OpSep),
                            AsmSigs.operand(sig,0),
                            AsmSigs.operand(sig,1),
                            AsmSigs.operand(sig,2)
                            );
                    break;
                    case 4:
                        operands = string.Format(RP.delimit(n4, OpSep),
                            AsmSigs.operand(sig,0),
                            AsmSigs.operand(sig,1),
                            AsmSigs.operand(sig,2),
                            AsmSigs.operand(sig,3)
                            );
                    break;
                    default:
                    break;
                }
                writer.WriteLine(string.Format(Pattern, form.Sig.Mnemonic, operands, form.OpCode.Format()));
            }

            return _forms;
        }
    }
}