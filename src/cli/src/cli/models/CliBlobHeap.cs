//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CliBlobHeap : ICliHeap<CliBlobHeap>
    {
        public MemoryAddress BaseAddress {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public CliBlobHeap(MemoryAddress @base, ByteSize size)
        {
            BaseAddress = @base;
            Size = size;
        }

        public CliHeapKind HeapKind
        {
            [MethodImpl(Inline)]
            get => CliHeapKind.Blob;
        }

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