//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Surrogates
    {
        public readonly struct UnaryPredicate<T> : IFunc<T,bit>
        {
            public OpIdentity Id {get;}

            readonly Z0.UnaryPredicate<T> F;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,bit>(UnaryPredicate<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            internal UnaryPredicate(Z0.UnaryPredicate<T> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            [MethodImpl(Inline)]
            internal UnaryPredicate(Z0.UnaryPredicate<T> f, string name)
            {
                F = f;
                Id = Identify.sfunc<T>(name);
            }

            [MethodImpl(Inline)]
            public bit Invoke(T a) => F(a);

            public Z0.UnaryPredicate<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,bit> AsFunc()
                => this.ToFunc();
        }
    }
}