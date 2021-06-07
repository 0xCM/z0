//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public ref struct AsciLine
    {
        public uint LineNumber {get;}

        public uint StartPos {get;}

        public ReadOnlySpan<byte> Content {get;}

        [MethodImpl(Inline)]
        public AsciLine(uint number, uint start, ReadOnlySpan<byte> src)
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
            => TextTools.format(this, buffer);
    }
}