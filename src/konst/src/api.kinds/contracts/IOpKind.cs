//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IOpKind<E> : IApiKey, ILiteralKind<E>
        where E : unmanaged, Enum
    {
        E ITypedLiteral<E>.Class
            => default;
    }

    public interface IOpKind<K,E> : IOpKind<E>
        where E : unmanaged, Enum
        where K : unmanaged, IOpKind<E>
    {
        K Kind => default;
    }
}