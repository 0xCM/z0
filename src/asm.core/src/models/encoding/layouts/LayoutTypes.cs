//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmLayouts
    {
        public readonly struct LayoutTypes
        {
            public readonly struct Imm : IAsmLayoutPart<Imm>
            {
                public SlotKind Kind => SlotKind.Imm;
            }

            public readonly struct Disp : IAsmLayoutPart<Disp>
            {
                public SlotKind Kind => SlotKind.Disp;
            }

            public readonly struct Sib : IAsmLayoutPart<Sib>
            {
                public SlotKind Kind => SlotKind.Sib;
            }

            public readonly struct ModRm : IAsmLayoutPart<ModRm>
            {
                public SlotKind Kind => SlotKind.ModRm;
            }

            public readonly struct OpCode : IAsmLayoutPart<OpCode>
            {
                public SlotKind Kind => SlotKind.OpCode;
            }

            public readonly struct Escape : IAsmLayoutPart<Escape>
            {
                public SlotKind Kind => SlotKind.Escape;
            }

            public readonly struct RexPrefix : IAsmLayoutPart<RexPrefix>
            {
                public SlotKind Kind => SlotKind.RexPrefix;
            }

            public readonly struct LegacyPrefix : IAsmLayoutPart<LegacyPrefix>
            {
                public SlotKind Kind => SlotKind.LegacyPrefix;
            }

            public readonly struct VexC5 : IAsmLayoutPart<VexC5>
            {
                public SlotKind Kind => SlotKind.VexC5;
            }

            public readonly struct VexC4 : IAsmLayoutPart<VexC4>
            {
                public SlotKind Kind => SlotKind.VexC4;
            }

            public readonly struct RxbSelect : IAsmLayoutPart<RxbSelect>
            {
                public SlotKind Kind => SlotKind.RxbSelect;
            }

            public readonly struct Vex : IAsmLayoutPart<Vex>
            {
                public SlotKind Kind => SlotKind.Vex;
            }
        }
    }
}