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

    /// <summary>
    /// Defines a reference to a mutable S-sequence
    /// </summary>
    public unsafe readonly struct Word<S>
        where S : unmanaged
    {
        readonly Index<S> Data;

        [MethodImpl(Inline)]
        internal Word(S[] src)
        {
            Data = src;
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref S this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref S this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<S>();
        }

        public Span<S> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<S> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}