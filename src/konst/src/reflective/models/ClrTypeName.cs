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
    /// Defines an assembly-qualified type name
    /// </summary>
    public readonly struct ClrTypeName : IName<string>, IEquatable<ClrTypeName>, IComparable<ClrTypeName>
    {
        public readonly string Content;

        [MethodImpl(Inline)]
        public ClrTypeName(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator ClrTypeName(string src)
            => new ClrTypeName(src);

        [MethodImpl(Inline)]
        public static implicit operator string(ClrTypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(ClrTypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(ClrTypeName x, ClrTypeName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(ClrTypeName x, ClrTypeName y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrTypeName x, ClrTypeName y)
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

        public Count32 Count
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
        public int CompareTo(ClrTypeName src)
            => api.compare(Content, src.Content);

        [MethodImpl(Inline), Ignore]
        public bool Equals(ClrTypeName src)
            => string.Equals(Content, src.Content);

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is ClrTypeName n && Equals(n);

        string IContented<string>.Content
            => Content;
    }
}