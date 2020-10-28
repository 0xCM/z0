//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    [Free]
    public interface ICmdExec
    {
        CmdId Id {get;}

        CmdResult Exec(CmdSpec cmd);
    }

    [Free]
    public interface ICmdExec<H> : ICmdExec
        where H : struct, ICmdExec<H>
    {

    }
}