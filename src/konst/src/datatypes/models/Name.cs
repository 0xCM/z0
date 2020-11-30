//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Names;

    [DataType]
    public readonly struct Name : IName<string>, IEquatable<Name>, IComparable<Name>
    {
        readonly string Data;

        [MethodImpl(Inline)]
        public Name(string src)
            => Data = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Data);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Data);
        }

        public string Content
        {
            [MethodImpl(Inline)]
            get => Data ?? EmptyString;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public ReadOnlySpan<char> View
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
            => api.compare(this, src);

        [MethodImpl(Inline), Ignore]
        public bool Equals(Name src)
            => string.Equals(Data, src.Data);

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
            => x.Data == y.Data;

        [MethodImpl(Inline)]
        public static bool operator !=(Name x, Name y)
            => x.Data != y.Data;

        public static Name Empty
        {
            [MethodImpl(Inline)]
            get => new Name(EmptyString);
        }
    }
}