//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct OneOrNone<T>
        where T : IEquatable<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public OneOrNone(T src)
            => Value = src;

        public MultiplicityKind Multiplicity
            => MultiplicityKind.ZeroOrOne;

        [MethodImpl(Inline)]
        public static implicit operator OneOrNone<T>(T src)
            => new OneOrNone<T>(src);
    }
}