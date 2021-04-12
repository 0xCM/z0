//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static Part;
    using static memory;

    public readonly struct NasmHexBlock
    {
        readonly ulong Lo;

        readonly ulong Hi;

        [MethodImpl(Inline)]
        public NasmHexBlock(byte size, ulong lo)
        {
            Lo = lo;
            Hi = (ulong)size << 56;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => cover(@as<NasmHexBlock,byte>(this), Size);
        }

        public byte Size
        {
            [MethodImpl(Inline)]
            get => (byte)(Hi >> 56);
        }
    }
}