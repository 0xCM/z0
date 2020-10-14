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
    [ApiDataType]
    public readonly struct ClrTypeName : IName<string>, IEquatable<ClrTypeName>, IComparable<ClrTypeName>
    {
        [MethodImpl(Inline)]
        public static ClrTypeName from(Type src)
            => new ClrTypeName(src.AssemblyQualifiedName);

        [MethodImpl(Inline)]
        public static ClrTypeName define(string src)
            => new ClrTypeName(string.Intern(src));

        [MethodImpl(Inline)]
        public static ClrTypeName define(StringRef src)
            => new ClrTypeName(src);

        readonly StringRef Content;

        [MethodImpl(Inline)]
        internal ClrTypeName(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator string(ClrTypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ClrTypeName(Type src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(ClrTypeName src)
            => src.Content.View;

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

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Content.GetHashCode();
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

        public string ShortName
        {
            [MethodImpl(Inline), Ignore]
            get => Content.Format().LeftOfFirst(Chars.Comma);
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