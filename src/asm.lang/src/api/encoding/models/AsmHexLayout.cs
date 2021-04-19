//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct AsmHexLayout
    {
        public LegacyPrefixSet Legacy;

        public RexPrefix Rex;

        public AsmOpCode OpCode;

        public ModRm ModRm;

        public Sib Sib;

        public AsmDx<uint> Dx;

        public Imm<uint> Imm;
    }
}