//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class AsmCaseBuilder : WfService<AsmCaseBuilder>
    {
        Index<AsmMnemonicCode,AsmMnemonicCode> Monics;

        Index<AsmMnemonicCode,AsmMnemonicCase> CaseSource;

        Index<AsmMnemonicCode,AsmStatements> CaseStatements;

        public AsmCaseBuilder()
        {
            Monics = ClrEnums.literals<AsmMnemonicCode>().Storage;
            CaseSource = new(Monics.Count);
            CaseStatements = new(Monics.Count);
        }

        public AsmStatements BuildStatements(AsmMnemonicCase @case)
        {
            var index = @case.Mnemonic;
            CaseSource[index] = @case;
            AddStatements(index);
            return CaseStatements[index];
        }

        void AddStatements(AsmMnemonicCode code)
        {
            ref var @case = ref CaseSource[code];
            var operands = @case.Operands.View;
            var count = operands.Length;
            CaseStatements[code] = alloc<AsmStatement>(count);
            var dst = CaseStatements[code].Edit;
            for(var i=0; i<count; i++)
                seek(dst,i) = new AsmStatement(code, skip(operands,i));
        }
    }
}