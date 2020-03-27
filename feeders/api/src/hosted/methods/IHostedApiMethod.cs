//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;

    public interface IHostedApiMethod : IApiMethod
    {
        ApiHost Host {get;}
    }
}