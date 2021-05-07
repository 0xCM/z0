//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CliHeaps
    {
        public readonly struct StringHeap : ICliHeap<StringHeap>
        {
            public MemoryAddress BaseAddress {get;}

            public ByteSize Size {get;}

            [MethodImpl(Inline)]
            public StringHeap(MemoryAddress @base, ByteSize size)
            {
                BaseAddress = @base;
                Size = size;
            }

            public CliHeapKind Kind => CliHeapKind.String;

            public unsafe ReadOnlySpan<byte> Data
            {
                [MethodImpl(Inline)]
                get => memory.cover<byte>(BaseAddress, Size);
            }

            public uint EntryCount
            {
                [MethodImpl(Inline)]
                get => count(this);
            }

            public string Format()
                => string.Format(memory.range(BaseAddress, Size).Format());

            public override string ToString()
                => Format();
        }
    }
}