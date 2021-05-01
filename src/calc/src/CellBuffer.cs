//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = PageBlocks;

    public readonly struct CellBuffer<T>
        where T : unmanaged, IDataCell
    {
        readonly MemoryRange Range;

        [MethodImpl(Inline)]
        public CellBuffer(MemoryRange range)
        {
            Range = range;
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref Range.Min.Ref<T>();
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => cover(First, CellCount);
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Edit;
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First,index);
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First,index);
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Range.Size/size<T>();
        }

        [MethodImpl(Inline)]
        public uint Copy(uint offset, uint cells, Span<T> dst)
            => api.copy(this,offset,cells,dst);
    }
}