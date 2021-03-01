//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TextBlock<N> : IDataTypeComparable<TextBlock<N>>
        where N : unmanaged, ITypeNat
    {
        readonly string Data;

        [MethodImpl(Inline)]
        public TextBlock(string src)
            => Data = src;

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => memory.cover(Data);
        }

        public string Text
        {
            [MethodImpl(Inline)]
            get => Data ?? EmptyString;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
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

        public bool IsWhitespace
        {
            [MethodImpl(Inline)]
            get => IsNonEmpty && string.IsNullOrWhiteSpace(Data);
        }

        public bool IsInterned
        {
            [MethodImpl(Inline)]
            get => string.IsInterned(Data) != null;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)(Data?.GetHashCode() ?? 0);
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.pad((int)default(N).NatValue),Data);

        public override string ToString()
            => Format();

        public bool Equals(TextBlock<N> src)
            => string.Equals(Data, src.Data);

        public bool Equals(TextBlock<N> src, bool insensitive)
            => insensitive
            ? string.Equals(Data, src.Data, StringComparison.CurrentCultureIgnoreCase)
            : string.Equals(Data, src.Data);

        public override bool Equals(object src)
            => src is TextBlock<N> x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(TextBlock<N> src)
            => string.Compare(Data, src.Data);

        [MethodImpl(Inline)]
        public static implicit operator TextBlock<N>(string src)
            => new TextBlock<N>(src);

        [MethodImpl(Inline)]
        public static implicit operator TextBlock<N>(char src)
            => new TextBlock<N>(src.ToString());

        [MethodImpl(Inline)]
        public static implicit operator string(TextBlock<N> src)
            => src.Data;

        public static TextBlock<N> Empty
        {
            [MethodImpl(Inline)]
            get => new TextBlock<N>(EmptyString);
        }
    }
}