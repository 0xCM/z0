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

    public struct AsmOpCode
    {
        uint Data;

        [MethodImpl(Inline)]
        public AsmOpCode(uint data)
            => Data = data;

        public byte Size
        {
            [MethodImpl(Inline)]
            get => Bits.effsize(Data);
        }

        public ref byte Lead
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,0);
        }

        public ref byte this[N0 n]
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes, 0);
        }

        public ref byte this[N1 n]
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes, 1);
        }

        public ref byte this[N2 n]
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes, 2);
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

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Data),0, 3);
        }

        public static AsmOpCode Empty
            => default;
    }
}