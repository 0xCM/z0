//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TextBlock : IDataTypeComparable<TextBlock>
    {
        readonly string Data;

        [MethodImpl(Inline)]
        public TextBlock(string src)
            => Data = src ?? EmptyString;

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
            => Data;

        public string Format(int? pad)
            => pad != null ? string.Format(RP.pad(pad.Value), Data) : Data;

        [MethodImpl(Inline)]
        public TextBlock Trim()
            => Data?.Trim() ?? EmptyString;

        [MethodImpl(Inline)]
        public TextBlock Replace(TextBlock match, TextBlock value)
            => Data?.Replace(match,value) ?? EmptyString;

        public bool Equals(TextBlock src)
            => string.Equals(Data, src.Data);

        public bool Equals(TextBlock src, bool insensitive)
            => insensitive
            ? string.Equals(Data, src.Data, StringComparison.CurrentCultureIgnoreCase)
            : string.Equals(Data, src.Data);

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