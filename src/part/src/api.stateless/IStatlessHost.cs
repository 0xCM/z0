//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IStatelessHost<H> : IStateless
        where H : IStatelessHost<H>, new()
    {
        Type IStateless.HostType
            => typeof(H);
    }

    public interface IStatelessHost<H,C> : IStatelessHost<H>
        where H : IStatelessHost<H,C>, new()
    {
        Type IStateless.ContractType
            => typeof(C);
    }
}