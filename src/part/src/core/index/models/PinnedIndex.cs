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
    using static memory;

    public unsafe class PinnedIndex<T> : IDisposable, IIndex<T>
        where T : unmanaged
    {
        readonly GCHandle Handle;

        readonly MemoryAddress Address;

        readonly Index<T> Buffer;

        [MethodImpl(Inline)]
        public PinnedIndex(T[] content)
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

        public unsafe struct PinnedCell
        {
            readonly T* pCell;

            [MethodImpl(Inline)]
            public PinnedCell(MemoryAddress @base, uint index)
            {
                pCell = (T*)(@base.Pointer<byte>() + size<T>()*index);
            }

            public ref T Content
            {
                [MethodImpl(Inline)]
                get => ref @ref(pCell);
            }

            public MemoryAddress Address
            {
                [MethodImpl(Inline)]
                get => address(pCell);
            }

            public ByteSize Size
            {
                [MethodImpl(Inline)]
                get => size<T>();
            }
        }


        public void Dispose()
        {
            Handle.Free();
        }
    }
}