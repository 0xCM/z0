//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class Surrogates
    {
        public readonly struct Func<R> : Z0.ISFuncApi<R>
        {
            internal readonly System.Func<R> F;

            [MethodImpl(Inline)]
            public static implicit operator System.Func<R>(Func<R> src)
                => src.F;

            [MethodImpl(Inline)]
            internal Func(System.Func<R> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
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

        public readonly struct Func<X0,R> : Z0.ISFuncApi<X0,R>
        {
            readonly System.Func<X0,R> F;

            [MethodImpl(Inline)]
            public static implicit operator System.Func<X0,R>(Func<X0,R> src)
                => src.F;

            [MethodImpl(Inline)]
            internal Func(System.Func<X0,R> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }

            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public R Invoke(X0 a) => F(a);

            public System.Func<X0,R> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }
        }

        public readonly struct Func<X0,X1,R> : Z0.ISFuncApi<X0,X1,R>
        {
            readonly System.Func<X0,X1,R> F;

            [MethodImpl(Inline)]
            public static implicit operator System.Func<X0,X1,R>(Func<X0,X1,R> src)
                => src.F;

            [MethodImpl(Inline)]
            internal Func(System.Func<X0,X1,R> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }
            
            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public R Invoke(X0 x0, X1 x1) => F(x0,x1);

            public System.Func<X0,X1,R> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }
        }

        public readonly struct Func<X0,X1,X2,R> : Z0.ISFuncApi<X0,X1,X2,R>
        {
            readonly System.Func<X0,X1,X2,R> F;

            [MethodImpl(Inline)]
            public static implicit operator System.Func<X0,X1,X2,R>(Func<X0,X1,X2,R> src)
                => src.F;

            [MethodImpl(Inline)]
            internal Func(System.Func<X0,X1,X2,R> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }

            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public R Invoke(X0 x0, X1 x1, X2 x2) => F(x0, x1, x2);

            public System.Func<X0,X1,X2,R> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }
        }
    }
}