//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    [ApiHost("api")]
    public readonly partial struct Tooling
    {
        [Op]
        public static ToolStatus status(ToolRunner runner)
            => runner.Status();

        [Op]
        public static ref ToolStatus status(ToolRunner runner, ref ToolStatus dst)
            => ref runner.Status(ref dst);
        
        internal static FolderPath ToolSourceDir
            => FolderPath.Define("J:/assets/tools");
    }
}