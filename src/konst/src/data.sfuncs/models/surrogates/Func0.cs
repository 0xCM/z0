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
        public readonly struct Func<R> : Z0.IFunc<R>
        {
            internal readonly System.Func<R> F;

            [MethodImpl(Inline)]
            public static implicit operator System.Func<R>(Func<R> src)
                => src.F;

            [MethodImpl(Inline)]
            internal Func(System.Func<R> f, OpIdentity id)
            {
                F = f;
                Id = id;
            }

            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public R Invoke() => F();

            public System.Func<R> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }
        }
    }
}