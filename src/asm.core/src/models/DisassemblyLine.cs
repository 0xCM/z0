//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public ref struct DisassemblyLine
    {
        public uint LineNumber {get;}

        public uint StartPos {get;}

        public ReadOnlySpan<byte> Content {get;}

        public MemoryAddress Offset;

        [MethodImpl(Inline)]
        public DisassemblyLine(uint number, uint start, ReadOnlySpan<byte> src)
        {
            LineNumber = number;
            StartPos = start;
            Content = src;
            Offset = 0;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public string Format(Span<char> buffer)
            => TextTools.format(TextTools.codes(Content), buffer);
    }
}