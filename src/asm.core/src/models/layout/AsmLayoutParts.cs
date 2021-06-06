//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmLayoutParts
    {
        public readonly struct Imm : IAsmLayoutPart<Imm>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.Imm;
        }

        public readonly struct Dx : IAsmLayoutPart<Dx>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.Dx;
        }

        public readonly struct Sib : IAsmLayoutPart<Sib>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.Sib;
        }

        public readonly struct ModRm : IAsmLayoutPart<ModRm>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.ModRm;
        }

        public readonly struct OpCode : IAsmLayoutPart<OpCode>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.OpCode;
        }

        public readonly struct Escape : IAsmLayoutPart<Escape>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.Escape;
        }

        public readonly struct RexPrefix : IAsmLayoutPart<RexPrefix>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.RexPrefix;
        }

        public readonly struct LegacyPrefix : IAsmLayoutPart<LegacyPrefix>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.LegacyPrefix;
        }

        public readonly struct VexC5 : IAsmLayoutPart<VexC5>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.VexC5;
        }

        public readonly struct RxbSelect : IAsmLayoutPart<RxbSelect>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.RxbSelect;
        }

        public readonly struct Vex : IAsmLayoutPart<Vex>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.Vex;
        }

        public readonly struct Xop : IAsmLayoutPart<Xop>
        {
            public AsmLayoutPart Kind => AsmLayoutPart.Xop;
        }
    }
}