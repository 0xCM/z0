//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Word
    {
        readonly Index<char> Data;

        [MethodImpl(Inline)]
        internal Word(char[] src)
        {
            Data = src;
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref char this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref char this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<char>();
        }

        public Span<char> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}