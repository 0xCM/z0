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

    /// <summary>
    /// Defines an assembly-qualified type name
    /// </summary>
    [ApiType]
    public readonly struct TypeName : IName<string>, IEquatable<TypeName>, IComparable<TypeName>
    {
        [MethodImpl(Inline)]
        public static TypeName from(Type src)
            => new TypeName(src.AssemblyQualifiedName);

        [Ignore]
        public string Content {get;}

        [MethodImpl(Inline)]
        public TypeName(string src)
            => Content = src;

        [MethodImpl(Inline), Ignore]
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
            get => Content.LeftOfFirst(Chars.Comma);
        }

        [MethodImpl(Inline), Ignore]
        public int CompareTo(TypeName src)
            => api.compare(Content, src.Content);

        [MethodImpl(Inline), Ignore]
        public bool Equals(TypeName src)
            => string.Equals(Content, src.Content);

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is TypeName n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator string(TypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator TypeName(Type src)
            => from(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(TypeName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(TypeName x, TypeName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(TypeName x, TypeName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(TypeName x, TypeName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(TypeName x, TypeName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(TypeName x, TypeName y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(TypeName x, TypeName y)
            => !x.Equals(y);
    }
}