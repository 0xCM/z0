//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [Op]
        public static ScriptEnvVars env()
        {
            var dst = new ScriptEnvVars();
            dst.DevRoot = (nameof(ScriptEnvVars.DevRoot), FS.dir(Environment.GetEnvironmentVariable("ZDev")));
            dst.Db = (nameof(ScriptEnvVars.Db), FS.dir(Environment.GetEnvironmentVariable("ZDb")));
            dst.Control = (nameof(ScriptEnvVars.Control), FS.dir(Environment.GetEnvironmentVariable("ZControl")));
            return dst;
        }
    }
}