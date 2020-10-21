//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ICmdExec
    {
        CmdId Id {get;}

        CmdResult Exec(CmdSpec cmd);
    }

    public interface ICmdExec<H> : ICmdExec
        where H : struct, ICmdExec<H>
    {

    }
}