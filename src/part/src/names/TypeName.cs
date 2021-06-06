//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Names;

    /// <summary>
    /// Defines the name of a type
    /// </summary>
    [Datatype]
    public readonly struct TypeName : IName<string>, IDataTypeComparable<TypeName>
    {
        readonly string Data;

        [MethodImpl(Inline)]
        public TypeName(string src)
            => Data = src;

        public bool Parametric
        {
            [MethodImpl(Inline)]
            get => TextQuery.fenced(Data, Chars.Lt, Chars.Gt);
        }

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

        public string Text
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

        [MethodImpl(Inline)]
        public int CompareTo(TypeName src)
            => api.compare(this, src);

        [MethodImpl(Inline)]
        public bool Equals(TypeName src)
            => string.Equals(Data, src.Data);


        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Name n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator TypeName(string src)
            => new TypeName(src);

        [MethodImpl(Inline)]
        public static implicit operator string(TypeName src)
            => src.Content;

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
            => x.Data == y.Data;

        [MethodImpl(Inline)]
        public static bool operator !=(TypeName x, TypeName y)
            => x.Data != y.Data;

        public static TypeName Empty
        {
            [MethodImpl(Inline)]
            get => new TypeName(EmptyString);
        }
    }
}