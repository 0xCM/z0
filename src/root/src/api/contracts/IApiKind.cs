//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiKind : IApiClass
    {

    }

    public interface IApiKind<E> : IApiKind, IApiClass<E>
        where E : unmanaged, Enum
    {
        E IApiClass<E>.Kind
            => Kind;
    }
}