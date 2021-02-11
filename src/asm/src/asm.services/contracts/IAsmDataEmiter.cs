//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmDataEmitter : IWfService
    {
        AsmRowSets<IceMnemonic> EmitAsmRows();

        Index<AsmCallRow> EmitCallRows();

        Index<AsmJmpRow> EmitJmpRows();

        void EmitSemantic();

        void EmitResBytes();

        ApiAsmDataset Run();
    }
}