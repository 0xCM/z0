//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IHostedApiMethod : IApiMethod
    {
        new IApiHost Host {get;}

        ApiHostUri IApiMethod.Host
            => Host.HostUri;
    }
}