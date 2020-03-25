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
        public readonly struct BinaryOp<T> : Z0.ISBinaryOpApi<T> 
        {
            readonly Z0.BinaryOp<T> F;
            
            public OpIdentity Id {get;}

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T,T>(BinaryOp<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            public static implicit operator BinaryOp<T>(Func<T,T,T> src)
                => src.ToBinaryOp();

            [MethodImpl(Inline)]
            internal BinaryOp(Z0.BinaryOp<T> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }

            [MethodImpl(Inline)]
            internal BinaryOp(Z0.BinaryOp<T> f, string name)            
            {
                this.F = f;
                this.Id = OpIdentity.sfunc<T>(name);
            }

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => F(a, b);

            public Z0.BinaryOp<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T,T,T> AsFunc()
                => this.ToFunc();
        }            
    }
}