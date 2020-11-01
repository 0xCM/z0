//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICmdRouter
    {
        CmdResult Dispatch(CmdSpec cmd);
    }

    public interface ICmdRouter<H> : ICmdRouter
        where H : ICmdRouter<H>
    {

    }

    public interface ICmdRouter<H,T> : ICmdRouter<H>
        where H : ICmdRouter<H>
        where T : struct, ICmdSpec<T>
    {

    }

}