//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using api = Names;

    /// <summary>
    /// Defines an assembly-qualified type name
    /// </summary>
    public readonly struct ClrMemberName : IName<string>, IEquatable<ClrMemberName>, IComparable<ClrMemberName>
    {
        [MethodImpl(Inline)]
        public static ClrMemberName from(FieldInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline)]
        public static ClrMemberName from(PropertyInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline)]
        public static ClrMemberName from(EventInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline)]
        public static ClrMemberName define(StringRef src)
            => new ClrMemberName(src);

        [MethodImpl(Inline)]
        public static ClrMemberName define(string src)
            => new ClrMemberName(string.Intern(src));

        readonly StringRef Content;

        [MethodImpl(Inline)]
        public ClrMemberName(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator string(ClrMemberName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(ClrMemberName src)
            => src.Content.View;

        [MethodImpl(Inline)]
        public static bool operator <(ClrMemberName x, ClrMemberName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(ClrMemberName x, ClrMemberName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(ClrMemberName x, ClrMemberName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(ClrMemberName x, ClrMemberName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(ClrMemberName x, ClrMemberName y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrMemberName x, ClrMemberName y)
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

        [MethodImpl(Inline), Ignore]
        public int CompareTo(ClrMemberName src)
            => api.compare(Content, src.Content);

        [MethodImpl(Inline), Ignore]
        public bool Equals(ClrMemberName src)
            => string.Equals(Content, src.Content);

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is ClrMemberName n && Equals(n);

        string IContented<string>.Content
            => Content;
    }
}