//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    using api = Names;

    /// <summary>
    /// Defines the name of an operation
    /// </summary>
    [Datatype]
    public readonly struct OperationName : IName<string>, IDataTypeComparable<OperationName>
    {
        readonly string Data;

        [MethodImpl(Inline)]
        public OperationName(string src)
            => Data = src;

        public bool Parametric
        {
            [MethodImpl(Inline)]
            get => Query.fenced(Data, Chars.Lt, Chars.Gt);
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
        public int CompareTo(OperationName src)
            => api.compare(this, src);

        [MethodImpl(Inline)]
        public bool Equals(OperationName src)
            => string.Equals(Data, src.Data);


        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Name n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator OperationName(string src)
            => new OperationName(src);

        [MethodImpl(Inline)]
        public static implicit operator string(OperationName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(OperationName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(OperationName x, OperationName y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(OperationName x, OperationName y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(OperationName x, OperationName y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(OperationName x, OperationName y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(OperationName x, OperationName y)
            => x.Data == y.Data;

        [MethodImpl(Inline)]
        public static bool operator !=(OperationName x, OperationName y)
            => x.Data != y.Data;

        public static OperationName Empty
        {
            [MethodImpl(Inline)]
            get => new OperationName(EmptyString);
        }
    }
}