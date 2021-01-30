//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public readonly struct ZeroOrMore<T> : IRule<ZeroOrMore<T>,T>
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

            public MultiplicityKind Multiplicity
                => MultiplicityKind.ZeroOrMore;

            [MethodImpl(Inline)]
            public ZeroOrMore(T[] src)
                => Elements = src;

            [MethodImpl(Inline)]
            public static implicit operator ZeroOrMore<T>(T[] src)
                => new ZeroOrMore<T>(src);
        }
    }
}