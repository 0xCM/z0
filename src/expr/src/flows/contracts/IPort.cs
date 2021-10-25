//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    [Free]
    public interface IPort
    {
        ReadOnlySpan<Channel> Inputs {get;}

        ReadOnlySpan<Channel> Outputs {get;}
    }
}