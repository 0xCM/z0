//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IApiView<S>
    {
        S Source {get;}
    }

    public interface IApiView<H,S> : IApiView<S>
        where H : IApiView<H,S>, new()
    {

    }
}