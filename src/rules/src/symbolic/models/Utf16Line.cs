//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public ref struct Utf16Line
    {
        public uint LineNumber {get;}

        public uint StartPos {get;}

        public ReadOnlySpan<char> Content {get;}

        [MethodImpl(Inline)]
        public Utf16Line(uint number, uint start, ReadOnlySpan<char> src)
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
    }
}