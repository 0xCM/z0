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

    [ApiHost(ApiNames.WfCmd)]
    public readonly struct Cmd
    {
        [Op]
        public static int execute(IWfShell wf, CmdId id, params CmdOption[] options)
        {
            return 0;
        }
    }
}