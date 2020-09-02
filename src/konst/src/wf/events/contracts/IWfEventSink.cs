//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEventSink : ISink<IWfEvent>, IDisposable
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfEventSink<H> : IWfEventSink
        where H : struct, IWfEventSink<H>
    {

    }
}