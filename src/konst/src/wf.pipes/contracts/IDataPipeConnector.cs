//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataPipeConnector<S,T>
        where S : struct
        where T : struct
    {
        void Flow(ReadOnlySpan<S> src);
    }
}