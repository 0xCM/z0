//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    public interface IReflector
    {
        [MethodImpl(Inline)]
        ITypeReflector<T> Reflect<T>()
            => TypeReflector<T>.Service;

        [MethodImpl(Inline)]
        ITypeReflector Reflect(Type t)
            => new TypeReflector(t);
    }
}