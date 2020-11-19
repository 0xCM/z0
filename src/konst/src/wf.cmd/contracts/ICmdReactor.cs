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

        CmdResult Invoke(ICmdSpec cmd);
    }

    [Free]
    public interface ICmdReactor<S,T> : ICmdReactor
        where S : struct, ICmdSpec<S>
        where T : struct
    {
        CmdId ICmdReactor.CmdId
            => default(S).CmdId;

        CmdResult<T> Invoke(S src);

        CmdResult ICmdReactor.Invoke(ICmdSpec src)
        {
            try
            {
                Invoke((S)src);
                return Cmd.ok(src);
            }
            catch(Exception e)
            {
                return Cmd.fail(src,e);
            }
        }
    }
}