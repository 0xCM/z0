//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmSlotTypes
    {
        public readonly struct Imm : IAsmSlotType<Imm>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.Imm;
        }

        public readonly struct Disp : IAsmSlotType<Disp>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.Disp;
        }

        public readonly struct Sib : IAsmSlotType<Sib>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.Sib;
        }

        public readonly struct ModRm : IAsmSlotType<ModRm>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.ModRm;
        }

        public readonly struct OpCode : IAsmSlotType<OpCode>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.OpCode;
        }

        public readonly struct Escape : IAsmSlotType<Escape>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.Escape;
        }

        public readonly struct RexPrefix : IAsmSlotType<RexPrefix>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.RexPrefix;
        }

        public readonly struct LegacyPrefix : IAsmSlotType<LegacyPrefix>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.LegacyPrefix;
        }

        public readonly struct VexC5 : IAsmSlotType<VexC5>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.VexC5;
        }

        public readonly struct VexC4 : IAsmSlotType<VexC4>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.VexC4;
        }

        public readonly struct RxbSelect : IAsmSlotType<RxbSelect>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.RxbSelect;
        }

        public readonly struct Vex : IAsmSlotType<Vex>
        {
            public LayoutSlotKind Kind => LayoutSlotKind.Vex;
        }
    }
}