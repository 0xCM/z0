//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public readonly struct Tools
    {
        public static IToolResultProcessor processor(IEnvPaths paths, FS.FilePath script)
            => new ToolResultProcessor(paths, script);
    }
}