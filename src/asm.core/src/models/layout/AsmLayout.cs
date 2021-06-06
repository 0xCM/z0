//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct AsmLayout
    {
        Cell128 Data;

        public const byte MaxSlotCount = 13;

        [MethodImpl(Inline)]
        internal AsmLayout(Cell128 data)
        {
            Data = data;
        }

        public Span<AsmLayoutSlot> Edit
        {
            [MethodImpl(Inline)]
            get => slice(recover<AsmLayoutSlot>(Data.Bytes), 0, SlotCount);
        }

        public ReadOnlySpan<AsmLayoutSlot> View
        {
            [MethodImpl(Inline)]
            get => slice(recover<AsmLayoutSlot>(Data.Bytes), 0, SlotCount);
        }

        public ref AsmLayoutSlot this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Edit,index);
        }

        public byte SlotCount
        {
            [MethodImpl(Inline)]
            get => skip(Data.Bytes, MaxSlotCount);

            [MethodImpl(Inline)]
            set => seek(Data.Bytes, MaxSlotCount) = value;
        }

        public ushort Id
        {
            [MethodImpl(Inline)]
            get => skip(recover<ushort>(Data.Bytes),7);

            [MethodImpl(Inline)]
            set => seek(recover<ushort>(Data.Bytes),7) = value;
        }
    }
}