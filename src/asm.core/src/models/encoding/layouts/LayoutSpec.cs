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

    partial struct AsmLayouts
    {
        public struct LayoutSpec
        {
            Cell128 Data;

            public const byte MaxSlotCount = 13;

            [MethodImpl(Inline)]
            internal LayoutSpec(Cell128 data)
            {
                Data = data;
            }

            public Span<Slot> Edit
            {
                [MethodImpl(Inline)]
                get => slice(recover<Slot>(Data.Bytes), 0, SlotCount);
            }

            public ReadOnlySpan<Slot> View
            {
                [MethodImpl(Inline)]
                get => slice(recover<Slot>(Data.Bytes), 0, SlotCount);
            }

            public ref Slot this[byte index]
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
}