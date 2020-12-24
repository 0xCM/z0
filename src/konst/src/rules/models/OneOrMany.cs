//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct OneOrMany<T>
        where T : IEquatable<T>
    {
        public Choices<T> Value {get;}

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
            insist(src.Length > 0, "At least one there must be");
            Value = src;
        }

        public MultiplicityKind Multiplicity
            => MultiplicityKind.OneOrMany;

        [MethodImpl(Inline)]
        public static implicit operator OneOrMany<T>(T[] src)
            => new OneOrMany<T>(src);
    }

}