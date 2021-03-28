//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Tooling;

    using static Part;

    [ApiHost]
    public readonly struct Tools
    {
        public static IToolResultProcessor processor(IEnvPaths paths, FS.FilePath script)
            => new ToolResultProcessor(paths, script);

        [MethodImpl(Inline), Op]
        public static Nasm nasm(IWfShell wf)
            => Nasm.create(wf);
    }
}