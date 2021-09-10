//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = PageBlocks;

    [ApiComplete]
    public unsafe struct PageBlock
    {
        public MemoryRange Range {get;}

        [MethodImpl(Inline)]
        public PageBlock(MemoryRange range)
        {
            Range = range;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Range.Size;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => cover<byte>(Range.Min.Pointer<byte>(), Range.Size);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Edit;
        }

        [MethodImpl(Inline)]
        public ref T Segment<T>(ByteSize offset)
            where T : unmanaged
                => ref @as<T>(seek(Edit,offset));

        public uint PageCount
        {
            [MethodImpl(Inline)]
            get => Range.Size/api.PageSize;
        }

        [MethodImpl(Inline)]
        public PageBlockInfo Describe()
            => api.describe(this);

        [MethodImpl(Inline)]
        public Span<T> Cells<T>()
            where T : unmanaged
                => recover<T>(Edit);

        // [MethodImpl(Inline)]
        // public Span<T> Cells<T>()
        //     where T : unmanaged
        //         => api.cells<T>(this).Edit;
    }
}