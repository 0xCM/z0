//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CliStringHeap : ICliHeap<CliStringHeap>
    {
        public MemoryAddress BaseAddress {get;}

        public ByteSize Size {get;}

        public CliHeapKind HeapKind {get;}

        [MethodImpl(Inline)]
        public CliStringHeap(MemoryAddress @base, ByteSize size, CliHeapKind kind)
        {
            BaseAddress = @base;
            Size = size;
            HeapKind = kind;
        }

        public unsafe ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => memory.cover<byte>(BaseAddress, Size);
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => CliHeaps.count(this);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Size != 0;
        }

        public string Format()
            => string.Format(memory.range(BaseAddress, Size).Format());

        public override string ToString()
            => Format();

        public static CliStringHeap Empty
        {
            [MethodImpl(Inline)]
            get => new CliStringHeap(0,0,0);
        }
    }
}