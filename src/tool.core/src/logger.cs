//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [Op]
        public static ToolLogger logger<T>(IWfShell context, T id)
            where T : unmanaged, Enum
                => logger(context, id.ToString());

        [Op]
        public static ToolLogger logger(IWfShell wf, string name)
        {
            var dst = wf.Paths.AppDataRoot + FileName.define(name, FileExtensions.StatusLog);
            return new ToolLogger(wf,dst);
        }
    }
}