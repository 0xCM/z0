//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.DiaSymReader;

    public interface IAppSymAdapter : INullity
    {

    }

    public interface IAppSymAdapter<A,C> : IAppSymAdapter
        where A : IAppSymAdapter<A,C>
        where C : class
    {

    }
}