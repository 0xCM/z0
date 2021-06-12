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

    public readonly struct text<N> : IDataTypeComparable<text<N>>
        where N : unmanaged, ITypeNat
    {
        readonly string Data;

        static int n
        {
            [MethodImpl(Inline)]
            get => (int)default(N).NatValue;
        }

        [MethodImpl(Inline)]
        public text(string src)
            => Data = empty(src) ? EmptyString : text.slice(src, 0, min(n, src.Length));

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => cover(Data);
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
            => string.Format(RP.pad(-n),Data);

        public override string ToString()
            => Format();

        public bool Equals(text<N> src)
            => string.Equals(Data, src.Data);

        public bool Equals(text<N> src, bool insensitive)
            => insensitive
            ? string.Equals(Data, src.Data, StringComparison.CurrentCultureIgnoreCase)
            : string.Equals(Data, src.Data);

        public override bool Equals(object src)
            => src is text<N> x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public int CompareTo(text<N> src)
            => string.Compare(Data, src.Data);

        [MethodImpl(Inline)]
        public static implicit operator text<N>(string src)
            => new text<N>(src);

        [MethodImpl(Inline)]
        public static implicit operator text<N>(char src)
            => new text<N>(src.ToString());

        [MethodImpl(Inline)]
        public static implicit operator string(text<N> src)
            => src.Data;

        public static text<N> Empty
        {
            [MethodImpl(Inline)]
            get => new text<N>(EmptyString);
        }
    }
}