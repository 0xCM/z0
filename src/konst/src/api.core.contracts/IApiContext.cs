//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IApiContext
    {

    }

    public interface IApiContext<H,C> : IApiContext, IStateful<C>
        where H : struct, IApiContext<H,C>
    {

    }
}