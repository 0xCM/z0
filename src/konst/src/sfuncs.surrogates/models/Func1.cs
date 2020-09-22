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
        public readonly struct Func<X0,R> : Z0.IFunc<X0,R>
        {
            readonly System.Func<X0,R> F;

            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public static implicit operator System.Func<X0,R>(Func<X0,R> src)
                => src.F;

            [MethodImpl(Inline)]
            internal Func(System.Func<X0,R> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            [MethodImpl(Inline)]
            public R Invoke(X0 a)
                => F(a);

            public System.Func<X0,R> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }
        }
    }
}