//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    public readonly struct FixedCells<T> : IFixedCells<T>
        where T : struct
    {
        public MemoryAddress Address {get;}

        public uint CellCount {get;}

        readonly Index<T> Source;

        [MethodImpl(Inline)]
        public FixedCells(MemoryAddress address, uint count)
        {
            Address = address;
            CellCount = count;
            Source = first(cover<Index<T>>(address,1));
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref Source.First;
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First,index);
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First,index);
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => core.size<T>();
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => cover<T>(First, CellCount);
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Edit;
        }
    }
}