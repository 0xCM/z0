//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolArgs : ITextual
    {
        readonly string[] Data;

        [MethodImpl(Inline)]
        public ToolArgs(string[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator ToolArgs(string[] src)
            => new ToolArgs(src);

        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<string> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref string this[ulong idx]
        {
            [MethodImpl(Inline)]
            get => ref Data[idx];
        }

        public ref string this[long idx]
        {
            [MethodImpl(Inline)]
            get => ref Data[idx];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public bool Empty
        {
            [MethodImpl(Inline)]
            get => (Data?.Length ?? 0) == 0;
        }

        public bool NonEmpty
        {
            [MethodImpl(Inline)]
            get => (Data?.Length ?? 0) != 0;
        }

        [MethodImpl(Inline)]
        public string Format()
            =>  string.Join(Chars.Space, Data);


        public override string ToString()
            => Format();
    }
}