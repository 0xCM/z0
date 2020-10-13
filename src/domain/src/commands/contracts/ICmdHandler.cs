//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public interface ICmdHandler<H>
        where H : struct, ICmdHandler<H>
    {
        CmdId Id {get;}

        ClrArtifactKey Host {get;}

        CmdResult Exec(CmdSpec cmd);
    }
}