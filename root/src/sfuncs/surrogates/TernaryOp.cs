//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Surrogates
    {
        public readonly struct TernaryOp<T> : Z0.IFSTernaryOpApi<T> 
        {
            readonly Z0.TernaryOp<T> F;
            
            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T,T,T>(TernaryOp<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            public static implicit operator TernaryOp<T>(Func<T,T,T,T> src)
                => src.ToTernaryOp();

            [MethodImpl(Inline)]
            internal TernaryOp(Z0.TernaryOp<T> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }

            [MethodImpl(Inline)]
            internal TernaryOp(Z0.TernaryOp<T> f, string name)            
            {
                this.F = f;
                this.Id = OpIdentity.contracted<T>(name);
            }

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) => F(a, b, c);

            public Z0.TernaryOp<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,T,T,T> AsFunc()
                => this.ToFunc();
        }            
    }
}