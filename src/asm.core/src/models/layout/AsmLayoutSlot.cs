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
    using static Bytes;

    public readonly struct AsmLayoutSlot<T>
        where T : unmanaged, IAsmLayoutPart<T>
    {
        public AsmLayoutPart Kind => default(T).Kind;
    }

    public readonly struct AsmLayoutSlot : IAsmLayoutSlot
    {
        readonly byte Data;

        [MethodImpl(Inline)]
        public AsmLayoutSlot(byte pos, AsmLayoutPart kind)
        {
            Data = or(pos, sll((byte)kind,4));
        }

        public byte Position
        {
            [MethodImpl(Inline)]
            get => and(Data,0xF0);
        }

        public AsmLayoutPart Kind
        {
            [MethodImpl(Inline)]
            get => (AsmLayoutPart)srl(Data,4);
        }
    }
}