//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType]
    public readonly struct Name : IName<string>, IEquatable<Name>, IComparable<Name>
    {
        public readonly string Content;

        [MethodImpl(Inline)]
        public Name(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator Name(string src)
            => new Name(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Name src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(Name x, Name y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(Name x, Name y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(Name x, Name y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(Name x, Name y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(Name x, Name y)
            => x.Content == y.Content;

        [MethodImpl(Inline)]
        public static bool operator !=(Name x, Name y)
            => x.Content != y.Content;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Content.GetHashCode();
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length * sizeof(char);
        }

        [MethodImpl(Inline)]
        public AsciSequence ToAsci()
            => asci.sequence(Content);

        [MethodImpl(Inline)]
        public int CompareTo(Name src)
            => Content.CompareTo(src.Content);

        [MethodImpl(Inline)]
        public bool Equals(Name src)
            => string.Equals(Content, src.Content);

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is Name n && Equals(n);

        string IContented<string>.Content
            => Content;
    }
}