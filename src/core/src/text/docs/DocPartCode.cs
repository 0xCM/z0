//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct DocPartCode
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public DocPartCode(byte a0)
        {
            Data = a0;
        }

        [MethodImpl(Inline)]
        public DocPartCode(byte a0, byte a1)
        {
            Data = (uint)a0 | ((uint)a1 << 8);
        }

        [MethodImpl(Inline)]
        public DocPartCode(byte a0, byte a1, byte a2)
        {
            Data = (uint)a0 | (uint)a1 << 8 | (uint)a2 << 16;
        }

        [MethodImpl(Inline)]
        public DocPartCode(byte a0, byte a1, byte a2, byte a3)
        {
            Data = (uint)a0 | (uint)a1 << 8 | (uint)a2 << 16 | (uint)a3 << 24;
        }

        ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }
    }
}