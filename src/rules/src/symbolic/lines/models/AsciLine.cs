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
        /// <summary>
        /// The 1-based document-relative line number
        /// </summary>
        public LineNumber LineNumber {get;}

        /// <summary>
        /// The line content
        /// </summary>
        public ReadOnlySpan<AsciSymbol> Content {get;}

        [MethodImpl(Inline)]
        public AsciLine(uint number, uint start, ReadOnlySpan<AsciSymbol> src)
        {
            LineNumber = number;
            Content = src;
        }

        [MethodImpl(Inline)]
        public AsciLine(uint number, ReadOnlySpan<byte> src)
        {
            LineNumber = number;
            Content = recover<byte,AsciSymbol>(src);
        }

        public ReadOnlySpan<AsciCode> Codes
        {
            [MethodImpl(Inline)]
            get => recover<AsciSymbol,AsciCode>(Content);
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

        public ref readonly AsciSymbol this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Content,index);
        }

        public ref readonly AsciSymbol this[long index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Content,index);
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
            get => new AsciLine(0,default(ReadOnlySpan<byte>));
        }
    }
}