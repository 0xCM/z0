//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    using api = Names;

    /// <summary>
    /// Defines the name of a member
    /// </summary>
    public readonly struct MemberName : IName<string>, IEquatable<MemberName>, IComparable<MemberName>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public MemberName(string src)
            => Content = src ?? EmptyString;

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
        public int CompareTo(MemberName src)
            => api.compare(Content, src.Content);

        [MethodImpl(Inline), Ignore]
        public bool Equals(MemberName src)
            => string.Equals(Content, src.Content);

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is MemberName n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator string(MemberName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator MemberName(FieldInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline)]
        public static implicit operator MemberName(PropertyInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline)]
        public static implicit operator MemberName(EventInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline)]
        public static implicit operator MemberName(MethodInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline)]
        public static implicit operator MemberName(MemberInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(MemberName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(MemberName x, MemberName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(MemberName x, MemberName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(MemberName x, MemberName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(MemberName x, MemberName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(MemberName x, MemberName y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(MemberName x, MemberName y)
            => !x.Equals(y);
    }
}