//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public ref struct UnicodeLine
    {
        public LineNumber LineNumber {get;}

        public ReadOnlySpan<char> Content {get;}

        [MethodImpl(Inline)]
        public UnicodeLine(uint number, uint start, ReadOnlySpan<char> src)
        {
            LineNumber = number;
            Content = src;
        }

        [MethodImpl(Inline)]
        public UnicodeLine(uint number, ReadOnlySpan<char> src)
        {
            LineNumber = number;
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
            => Lines.format(this);

        public static UnicodeLine Empty
        {
            [MethodImpl(Inline)]
            get => new UnicodeLine(0,0,default);
        }
    }
}