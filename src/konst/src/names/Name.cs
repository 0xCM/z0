//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Names;

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
        public static implicit operator string(Name src)
            => src.Content;

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

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => z.address(Content);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Address;
        }

        public Count Count
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

        [MethodImpl(Inline), Ignore]
        public int CompareTo(Name src)
            => api.compare(this,src);

        [MethodImpl(Inline), Ignore]
        public bool Equals(Name src)
            => string.Equals(Content, src.Content);

        [Ignore]
        string IContented<string>.Content
            => Content;

        [Ignore]
        string ITextual.Format()
            => Content;

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Name n && Equals(n);
    }
}