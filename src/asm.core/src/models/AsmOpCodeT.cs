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

    public struct AsmOpCode<T>
        where T : unmanaged, Enum
    {
        uint Data;

        [MethodImpl(Inline)]
        internal AsmOpCode(uint @base, T kind)
        {
            Data = (@base & 0xFFFFFF) | (uint32(kind) << 24);
        }

        public T Kind
        {
            [MethodImpl(Inline)]
            get => @as<T>(Data >> 24);
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Data),0,3);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        public string Format()
            => AsmOpCodes.format(this);

        public override string ToString()
            => Format();
    }
}