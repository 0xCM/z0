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

        public ref byte Byte0
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,0);
        }

        public ref byte Byte1
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes, 1);
        }

        public ref byte Byte2
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

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Data),0, 3);
        }

        public static AsmOpCode Empty
            => default;
    }
}