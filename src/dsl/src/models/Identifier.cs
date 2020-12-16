//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
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
        readonly string Data;

        [MethodImpl(Inline)]
        public Identifier(string src)
            => Data = src;

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
            get => alg.hash.calc(Data);
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

        [MethodImpl(Inline), Ignore]
        public int CompareTo(Identifier src)
            => Names.compare(Data, src.Data);

        [MethodImpl(Inline), Ignore]
        public bool Equals(Identifier src)
            => string.Equals(Data, src.Data);

        [Ignore]
        string IContented<string>.Content
            => Content;

        [Ignore]
        string ITextual.Format()
            => Content;

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
            => x.Data == y.Data;

        [MethodImpl(Inline)]
        public static bool operator !=(Identifier x, Identifier y)
            => x.Data != y.Data;

        public static Identifier Empty
        {
            [MethodImpl(Inline)]
            get => new Identifier(EmptyString);
        }
    }
}