//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static Bytes;

    public readonly struct AsmLayoutSlot : IAsmLayoutSlot
    {
        readonly byte Data;

        [MethodImpl(Inline)]
        public AsmLayoutSlot(byte pos, LayoutSlotKind kind)
        {
            Data = or(pos, sll((byte)kind,4));
        }

        public byte Position
        {
            [MethodImpl(Inline)]
            get => and(Data,0xF0);
        }

        public LayoutSlotKind Kind
        {
            [MethodImpl(Inline)]
            get => (LayoutSlotKind)srl(Data,4);
        }
    }
}