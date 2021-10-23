//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Multiplicity
    {
        public readonly struct ZeroOrMany<T>
            where T : IEquatable<T>
        {
            public Index<T> Elements {get;}

            public bool IsZero
            {
                [MethodImpl(Inline)]
                get => Elements.Count == 0;
            }

            public bool IsMore
            {
                [MethodImpl(Inline)]
                get => Elements.Count > 0;
            }

            public MultiplicityKind Kind
                => MultiplicityKind.ZeroOrMany;

            [MethodImpl(Inline)]
            public ZeroOrMany(T[] src)
                => Elements = src;

            [MethodImpl(Inline)]
            public static implicit operator ZeroOrMany<T>(T[] src)
                => new ZeroOrMany<T>(src);
        }

        public readonly struct OneOrMany<T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public OneOrMany(Index<T> src)
                => Elements = src;

            public bool IsZero
            {
                [MethodImpl(Inline)]
                get => Elements.Count == 0;
            }

            public bool IsMore
            {
                [MethodImpl(Inline)]
                get => Elements.Count > 0;
            }

            public MultiplicityKind Kind
                => MultiplicityKind.OneOrMany;

            [MethodImpl(Inline)]
            public static implicit operator OneOrMany<T>(T[] src)
                => new OneOrMany<T>(src);
        }

        /// <summary>
        /// Specifies that an element either occurs once or not at all
        /// </summary>
        public readonly struct OneOrNone<T>
            where T : IEquatable<T>
        {
            public Option<T> Element {get;}

            [MethodImpl(Inline)]
            public OneOrNone(T src)
                => Element = src;


            public bool IsOne
            {
                [MethodImpl(Inline)]
                get => Element.Exists;
            }


            public bool IsNone
            {
                [MethodImpl(Inline)]
                get => !Element.Exists;
            }

            public MultiplicityKind Multiplicity
                => MultiplicityKind.ZeroOrOne;

            [MethodImpl(Inline)]
            public static implicit operator OneOrNone<T>(T src)
                => new OneOrNone<T>(src);
        }
    }
}