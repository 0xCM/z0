//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfWorker
    {

    }

    [Free]
    public interface IWfWorker<H> : IWfWorker
        where H : struct, IWfWorker<H>
    {

    }
}