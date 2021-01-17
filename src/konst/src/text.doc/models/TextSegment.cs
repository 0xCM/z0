//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an index-delimited text segment source from a <see cref='TextLine'/>
    /// </summary>
    public readonly struct TextSegment
    {
        public TextLine Source {get;}

        public uint FirstIndex {get;}

        public uint LastIndex {get;}

        [MethodImpl(Inline)]
        public TextSegment(TextLine src, uint first, uint last)
        {
            Source = src;
            FirstIndex = first;
            LastIndex = last;
        }

        public TextBlock Content
        {
            [MethodImpl(Inline)]
            get => Source.Segment(FirstIndex, LastIndex);
        }
    }
}