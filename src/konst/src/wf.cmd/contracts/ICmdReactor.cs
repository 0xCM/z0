//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdReactor : IWfService
    {
        CmdId CmdId {get;}

        ValueType Process(ICmdSpec src);
    }

    [Free]
    public interface ICmdReactor<S,T> : ICmdReactor
        where S : struct, ICmdSpec<S>
        where T : struct
    {
        CmdId ICmdReactor.CmdId
            => default(S).CmdId;

        T Process(S src);

        ValueType ICmdReactor.Process(ICmdSpec src)
            => Process((S)src);
    }

    [Free]
    public interface ICmdReactor<H,S,T> : ICmdReactor<S,T>, IWfService<H>
        where H : ICmdReactor<H,S,T>, new()
        where S : struct, ICmdSpec<S>
        where T : struct
    {

    }
}