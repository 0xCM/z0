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
        public readonly struct OneOrMany<T> : IRule<OneOrMany<T>,T>
            where T : IEquatable<T>
        {
            public Index<T> Value {get;}

            public bool IsOne
            {
                [MethodImpl(Inline)]
                get => Value.Count == 1;
            }

            public bool IsMany
            {
                [MethodImpl(Inline)]
                get => Value.Count > 1;
            }

            [MethodImpl(Inline)]
            public OneOrMany(T[] src)
            {
                root.require(src.Length > 0, () => "At least one there must be");
                Value = src;
            }

            public MultiplicityKind Multiplicity
                => MultiplicityKind.OneOrMany;

            [MethodImpl(Inline)]
            public static implicit operator OneOrMany<T>(T[] src)
                => new OneOrMany<T>(src);
        }

    }
}