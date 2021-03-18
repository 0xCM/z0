//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiKind : ILiteralKind, IApiClass
    {

    }

    public interface IApiKind<E> : IApiKind, ILiteralKind<E>, IApiClass<E>
        where E : unmanaged, Enum
    {

        new E Kind
            => (this as IApiClass<E>).Kind;

        E IApiClass<E>.Kind
            => Kind;

        E ITypedLiteral<E>.Class
            => default;
    }

    public interface IApiKind<K,E> : IApiKind<E>
        where E : unmanaged, Enum
        where K : unmanaged, IApiKind<E>
    {

    }
}