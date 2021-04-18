//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    public readonly struct PinnedIndex<T> : IDisposable, IIndex<T>
    {
        readonly GCHandle Handle;

        readonly MemoryAddress Address;

        readonly Index<T> Buffer;

        [MethodImpl(Inline)]
        public PinnedIndex(T[] content)
            : this()
        {
            Handle = GCHandle.Alloc(this);
            Address = Handle.AddrOfPinnedObject();
            Buffer = content;
        }

        [MethodImpl(Inline)]
        public PinnedCell Cell(uint index)
            => new PinnedCell(Address, index);

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Buffer.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Buffer.Length;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Buffer.Storage;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Buffer.Edit;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Buffer.View;
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Buffer[index];
        }

        public struct PinnedCell
        {
            readonly MemoryAddress Enclosure;

            readonly uint Index;

            public ref T Content
            {
                [MethodImpl(Inline)]
                get => ref Enclosure.Ref<PinnedIndex<T>>()[Index];
            }

            [MethodImpl(Inline)]
            public PinnedCell(MemoryAddress enclosure, uint index)
            {
                Enclosure = enclosure;
                Index = index;
            }
        }


        public void Dispose()
        {
            Handle.Free();
        }
    }
}