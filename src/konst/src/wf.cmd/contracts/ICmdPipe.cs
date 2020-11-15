//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdPipe : IWfService
    {
        Outcome<ValueType> Process(ICmdSpec cmd);

        Outcome<T> Process<S,T>(S cmd)
            where S : struct, ICmdSpec<S>
            where T : struct;

        ReadOnlySpan<Outcome<T>> Process<S,T>(ReadOnlySpan<S> src, bool pll)
            where S : struct, ICmdSpec<S>
            where T : struct;
    }

    public interface ICmdPipe<H> : ICmdPipe, IWfService<H>
        where H : ICmdPipe<H>, new()
    {

    }

}