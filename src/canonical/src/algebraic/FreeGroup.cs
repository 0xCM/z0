//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFreeGroup<S> : IGroupA<S>, IFreeMonoid<S>
        where S : IFreeGroup<S>, new()
    {

    }

    public interface IFreeGroup<S,T> : IFreeGroup<S>
        where S : IFreeGroup<S,T>, new()
    {

    }
}