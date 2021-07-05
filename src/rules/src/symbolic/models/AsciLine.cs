//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public ref struct AsciLine
    {
        /// <summary>
        /// The 1-based document-relative line number
        /// </summary>
        public LineNumber LineNumber {get;}

        /// <summary>
        /// The document-relative index of the first character in the represented line
        /// </summary>
        public uint StartPos {get;}

        /// <summary>
        /// The line content
        /// </summary>
        public ReadOnlySpan<AsciCode> Content {get;}

        [MethodImpl(Inline)]
        public AsciLine(uint number, uint start, ReadOnlySpan<AsciCode> src)
        {
            LineNumber = number;
            StartPos = start;
            Content = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public int RenderLength
        {
            [MethodImpl(Inline)]
            get => Content.Length + LineNumber.RenderLength;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        public string Format()
        {
            Span<char> buffer = stackalloc char[RenderLength];
            var i=0u;
            Lines.render(this, ref i, buffer);
            return text.format(buffer);
        }

        public static AsciLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsciLine(0,0,default);
        }
    }
}