//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface ICmdNode : IWfService
    {
        CmdId CmdId {get;}

        ValueType Process(ICmdSpec src);
    }

    [Free]
    public interface ICmdNode<S,T> : ICmdNode
        where S : struct, ICmdSpec<S>
        where T : struct
    {
        CmdId ICmdNode.CmdId
            => default(S).CmdId;

        T Process(S src);

        ValueType ICmdNode.Process(ICmdSpec src)
            => Process((S)src);
    }

    [Free]
    public interface ICmdNode<H,S,T> : ICmdNode<S,T>, IWfService<H>
        where H : ICmdNode<H,S,T>, new()
        where S : struct, ICmdSpec<S>
        where T : struct
    {

    }
}