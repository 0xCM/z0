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
    public readonly struct PageBuffer
    {
        readonly Index<byte> Content;

        [MethodImpl(Inline)]
        public PageBuffer(MemoryRange range, Index<byte> src)
        {
            Range = range;
            Content = src;
        }

        public MemoryRange Range {get;}

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

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