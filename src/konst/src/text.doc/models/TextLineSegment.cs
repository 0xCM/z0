//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a line of text in the context of a line-oriented text data source
    /// </summary>
    public readonly struct TextLineSegment
    {
        public TextLine Source {get;}

        public uint FirstIndex {get;}

        public uint LastIndex {get;}

        public TextLineSegment(TextLine src, uint first, uint last)
        {
            Source = src;
            FirstIndex = first;
            LastIndex = last;
        }

        public TextBlock Content
        {
            get => default;
        }
    }
}