//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static Bytes;

    partial struct AsmLayouts
    {
        public readonly struct Slot : IAsmLayoutSlot
        {
            readonly byte Data;

            [MethodImpl(Inline)]
            public Slot(byte pos, SlotKind kind)
            {
                Data = or(pos, sll((byte)kind,4));
            }

            public byte Position
            {
                [MethodImpl(Inline)]
                get => and(Data,0xF0);
            }

            public SlotKind Kind
            {
                [MethodImpl(Inline)]
                get => (SlotKind)srl(Data,4);
            }
        }
    }
}