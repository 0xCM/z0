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
    public readonly struct ClrMemberName : IDataTypeComparable<ClrMemberName>
    {
        internal readonly MemberInfo Source;

        string NameContent
        {
            [MethodImpl(Inline)]
            get => Source.Name;
        }

        public Name Name
        {
            [MethodImpl(Inline)]
            get => Source.Name;
        }

        [MethodImpl(Inline)]
        public ClrMemberName(MemberInfo src)
            => Source = src;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)NameContent.GetHashCode();
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => NameContent.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => NameContent.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length * sizeof(char);
        }

        [MethodImpl(Inline), Ignore]
        public int CompareTo(ClrMemberName src)
            => api.compare(NameContent, src.NameContent);

        [MethodImpl(Inline), Ignore]
        public bool Equals(ClrMemberName src)
            => string.Equals(NameContent, src.NameContent);

        [MethodImpl(Inline)]
        public string Format()
            => NameContent;

        public override string ToString()
            => NameContent;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is ClrMemberName n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator string(ClrMemberName src)
            => src.NameContent;

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberName(FieldInfo src)
            => new ClrMemberName(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberName(PropertyInfo src)
            => new ClrMemberName(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberName(EventInfo src)
            => new ClrMemberName(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberName(MethodInfo src)
            => new ClrMemberName(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrMemberName(MemberInfo src)
            => new ClrMemberName(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(ClrMemberName src)
            => src.NameContent;

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
    }
}