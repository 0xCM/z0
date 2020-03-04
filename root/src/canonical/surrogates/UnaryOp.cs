//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct UnaryFuncSurrogate<A,B> : IUnaryFunc<A,B>
    {
        readonly Func<A,B> f;

        [MethodImpl(Inline)]
        internal UnaryFuncSurrogate(Func<A,B> f, OpIdentity id)            
        {
            this.f = f;
            this.Id = id;
        }

        public OpIdentity Id {get;}

        [MethodImpl(Inline)]
        public B Invoke(A a) => f(a);
    }

    /// <summary>
    /// Captures a delegate that is exposed as a unary operator
    /// </summary>
    public readonly struct UnaryOpSurrogate<T> : IUnaryOp<T>
    {
        public readonly string Name;

        readonly Func<T,T> f;

        [MethodImpl(Inline)]
        internal UnaryOpSurrogate(Func<T,T> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public T Invoke(T a) => f(a);
    }
}