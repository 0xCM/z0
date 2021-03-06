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

        public ref byte Lead
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,0);
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

        [MethodImpl(Inline)]
        public static AsmOpCode operator|(AsmOpCode x, AsmOpCode y)
            => new AsmOpCode(x.Data | y.Data);
    }
}