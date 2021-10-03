//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public unsafe readonly struct Label
    {
        readonly ulong Storage;

        [MethodImpl(Inline)]
        public Label(MemoryAddress @base, byte length)
        {
            Storage = (ulong)@base | (1ul << 56);
        }

        public byte Length
        {
            [MethodImpl(Inline)]
            get => (byte)(Storage >> 56);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*2;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => (MemoryAddress)(Storage & 0x00FFFFFF_FFFFFFFFul);
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => core.cover(Address.Pointer<char>(), Length);
        }

        public string Format()
            => new string(Data);

        public override string ToString()
            => Format();

        public static Label Empty => default;
    }
}