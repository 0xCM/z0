//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using api = Names;

    /// <summary>
    /// Defines the name of a member
    /// </summary>
    public readonly struct ClrMemberName : IDataTypeComparable<ClrMemberName>
    {
        public Name Name {get;}

        [MethodImpl(Inline)]
        public ClrMemberName(MemberInfo src)
            => Name = src.Name.Replace(Chars.Pipe, (char)SymNotKind.Chi);

        [MethodImpl(Inline)]
        public ClrMemberName(string src)
            => Name = (src ?? EmptyString).Replace(Chars.Pipe, (char)SymNotKind.Chi);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Name.GetHashCode();
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Name.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Name.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length * sizeof(char);
        }

        [MethodImpl(Inline), Ignore]
        public int CompareTo(ClrMemberName src)
            => api.compare(Name, src.Name);

        [MethodImpl(Inline), Ignore]
        public bool Equals(ClrMemberName src)
            => string.Equals(Name, src.Name);

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Name;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is ClrMemberName n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator string(ClrMemberName src)
            => src.Name;

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
            => src.Name;

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