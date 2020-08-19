//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Names;

    /// <summary>
    /// Defines a fully-qualified type name
    /// </summary>
    public readonly struct FullTypeName : IName<string>, IEquatable<FullTypeName>, IComparable<FullTypeName>
    {
        public readonly string Content;

        [MethodImpl(Inline)]
        public FullTypeName(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator FullTypeName(string src)
            => new FullTypeName(src);

        [MethodImpl(Inline)]
        public static implicit operator string(FullTypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(FullTypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(FullTypeName x, FullTypeName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(FullTypeName x, FullTypeName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(FullTypeName x, FullTypeName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(FullTypeName x, FullTypeName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(FullTypeName x, FullTypeName y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(FullTypeName x, FullTypeName y)
            => !x.Equals(y);

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
            get => address(Content);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Address;
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

        [MethodImpl(Inline), Ignore]
        public int CompareTo(FullTypeName src)
            => api.compare(Content, src.Content);

        [MethodImpl(Inline), Ignore]
        public bool Equals(FullTypeName src)
            => string.Equals(Content, src.Content);

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is FullTypeName n && Equals(n);

        string IContented<string>.Content
            => Content;
    }
}