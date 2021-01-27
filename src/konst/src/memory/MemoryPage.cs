//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Captures the content of a page in memory
    /// </summary>
    public readonly struct MemoryPage
    {
        public static Index<MemoryPage> pages(MemoryRange range, ushort size = PageSize)
        {
            var count = (uint)(range.Size/size);
            var buffer = alloc<MemoryPage>(count);
            var current = range.Min;
            for(var i=0; i<count; i++)
            {
                buffer[i] = create((current, current + size), size);
                current += size;
            }
            return buffer;
        }

        public static MemoryPage create(MemoryRange range, ushort size = PageSize)
            => new MemoryPage(range, memory.alloc<byte>(size));

        [MethodImpl(Inline)]
        public static MemoryPage create(MemoryRange range, Index<byte> content)
            => new MemoryPage(range, content);

        readonly Index<byte> Content;

        [MethodImpl(Inline)]
        public MemoryPage(MemoryRange range, Index<byte> src)
        {
            Range = range;
            Content = src;
        }

        public MemoryRange Range {get;}

        public ByteSize Size => Content.Length;

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Content.View;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Content.Edit;
        }
    }
}