//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiKind : IApiKey, ILiteralKind
    {

    }

    public interface IApiKind<E> : IApiKind, ILiteralKind<E>
        where E : unmanaged, Enum
    {
        E ITypedLiteral<E>.Class
            => default;
    }

    public interface IApiKind<K,E> : IApiKind<E>
        where E : unmanaged, Enum
        where K : unmanaged, IApiKind<E>
    {
        K Kind => default;
    }
}