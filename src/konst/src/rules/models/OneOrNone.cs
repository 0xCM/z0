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

    public readonly struct OneOrNone<T>
        where T : IEquatable<T>
    {
        public Option<T> Value {get;}

        public bool IsOne
        {
            [MethodImpl(Inline)]
            get => Value.IsSome();
        }

        public bool IsNone
        {
            [MethodImpl(Inline)]
            get => Value.IsNone();
        }

        [MethodImpl(Inline)]
        public OneOrNone(T src)
        {
            Value = some(src);
        }

        public MultiplicityKind Multiplicity
            => MultiplicityKind.ZeroOrOne;

        [MethodImpl(Inline)]
        public static implicit operator OneOrNone<T>(T src)
            => new OneOrNone<T>(src);
    }
}