//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    partial class Surrogates
    {
        /// <summary>
        /// Defines a structured surrogate over an emitter
        /// </summary>
        public readonly struct Func<R> : IFunc<R>
        {
            internal readonly System.Func<R> F;

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

            [MethodImpl(Inline)]
            public static implicit operator System.Func<R>(Func<R> src)
                => src.F;
        }
    }
}