//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a legal identifier
    /// </summary>
    [Datatype]
    public readonly struct Identifier : IIdentifier<Identifier>
    {
        public Name Content {get;}

        [MethodImpl(Inline)]
        public Identifier(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public Identifier(Name src)
            => Content = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => Content.View;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Content.Hash;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Content.Count;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        [MethodImpl(Inline)]
        public int CompareTo(Identifier src)
            => Content.CompareTo(src.Content);

        [MethodImpl(Inline)]
        public bool Equals(Identifier src)
            => Content.Equals(src.Content);

        public override string ToString()
            => Content;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Identifier n && Equals(n);

        [MethodImpl(Inline)]
        public static implicit operator Identifier(string src)
            => new Identifier(src);

        [MethodImpl(Inline)]
        public static implicit operator Identifier(Name src)
            => new Identifier(src);

        [MethodImpl(Inline)]
        public static implicit operator Name(Identifier src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator string(Identifier src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Identifier src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator <(Identifier x, Identifier y)
            => x.CompareTo(y) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(Identifier x, Identifier y)
            => x.CompareTo(y) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(Identifier x, Identifier y)
            => x.CompareTo(y) > 0;

        [MethodImpl(Inline)]
        public static bool operator >=(Identifier x, Identifier y)
            => x.CompareTo(y) >= 0;

        [MethodImpl(Inline)]
        public static bool operator ==(Identifier x, Identifier y)
            => x.Content == y.Content;

        [MethodImpl(Inline)]
        public static bool operator !=(Identifier x, Identifier y)
            => x.Content != y.Content;

        public static Identifier Empty
        {
            [MethodImpl(Inline)]
            get => new Identifier(Name.Empty);
        }
    }
}