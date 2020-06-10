//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TypeReflector<F> : ITypeReflector<F>
    {
        public static ITypeReflector<F> Service => default(TypeReflector<F>);
    }

    public readonly struct TypeReflector : ITypeReflector
    {
        [MethodImpl(Inline)]
        public static ITypeReflector Create(Type src)
            => new TypeReflector(src);

        [MethodImpl(Inline)]
        public static ITypeReflector<T> Create<T>()
            => TypeReflector<T>.Service;

        [MethodImpl(Inline)]
        public TypeReflector(Type t)
        {
            Type = t;
        }

        public Type Type {get;}
    }

}