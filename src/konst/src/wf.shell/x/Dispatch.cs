//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Part;

    partial class XWf
    {
        [Op]
        public static Task<CmdResult> Dispatch<T>(this T cmd, IWfShell wf)
            where T : struct, ICmdSpec
                => wf.Dispatch(cmd);
    }
}