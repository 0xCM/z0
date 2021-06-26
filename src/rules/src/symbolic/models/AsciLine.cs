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
        /// <value></value>
        public uint LineNumber {get;}

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

        public string Format(Span<char> buffer)
            => SymbolicRender.format(this, buffer);

        public string Format()
        {
            Span<char> dst = stackalloc char[Content.Length];
            return SymbolicRender.format(this, dst);
        }
    }
}