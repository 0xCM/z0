//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
        public readonly struct StringHeap : IHeap<StringHeap>
        {
            public MemoryAddress BaseAddress {get;}

            public ByteSize Size {get;}

            [MethodImpl(Inline)]
            public StringHeap(MemoryAddress @base, ByteSize size)
            {
                BaseAddress = @base;
                Size = size;
            }

            public HeapKind Kind => HeapKind.String;

            public unsafe ReadOnlySpan<byte> Data
            {
                [MethodImpl(Inline)]
                get => memory.cover<byte>(BaseAddress, Size);
            }

            public string Format()
                => string.Format(memory.range(BaseAddress, Size).Format());

            public override string ToString()
                => Format();
        }
    }
}