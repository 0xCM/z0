//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ZeroOrMore<T>
    {
        public Choices<T> Value {get;}

        public bool IsZero
        {
            [MethodImpl(Inline)]
            get => Value.Count == 0;
        }

        public bool IsMore
        {
            [MethodImpl(Inline)]
            get => Value.Count > 0;
        }

        public MultiplicityKind Multiplicity
            => MultiplicityKind.ZeroOrMore;

        [MethodImpl(Inline)]
        public ZeroOrMore(T[] src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator ZeroOrMore<T>(T[] src)
            => new ZeroOrMore<T>(src);
    }

}