//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = TextBlocks;

    public readonly struct TextBlock : IEquatable<TextBlock>, IComparable<TextBlock>
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public TextBlock(string src)
            => Content = src;

        public Span<char> Edit
        {
            [MethodImpl(Inline)]
            get => memory.cover(Content);
        }

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => memory.cover(Content);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content?.Length ?? 0;
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
            get => IsNonEmpty && string.IsNullOrWhiteSpace(Content);
        }

        public bool IsInterned
        {
            [MethodImpl(Inline)]
            get => string.IsInterned(Content) != null;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => api.hash(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        [MethodImpl(Inline)]
        public bool Equals(TextBlock src)
            => string.Equals(Content, src.Content);

        public override bool Equals(object src)
            => src is TextBlock x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(TextBlock src)
            => string.Compare(Content, src.Content);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(string src)
            => new TextBlock(src);

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(char src)
            => new TextBlock(src.ToString());

        [MethodImpl(Inline)]
        public static implicit operator string(TextBlock src)
            => src.Content;

        public static TextBlock Empty
        {
            [MethodImpl(Inline)]
            get => new TextBlock(EmptyString);
        }
    }
}