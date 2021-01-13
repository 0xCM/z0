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

    public readonly struct TextBlock : IDataTypeComparable<TextBlock>
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
            get => api.hash(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data;

        [MethodImpl(Inline)]
        public bool Equals(TextBlock src)
            => string.Equals(Data, src.Data);

        public override bool Equals(object src)
            => src is TextBlock x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(TextBlock src)
            => string.Compare(Data, src.Data);

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
            => src.Data;

        public static TextBlock Empty
        {
            [MethodImpl(Inline)]
            get => new TextBlock(EmptyString);
        }
    }
}