//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct ShellEnv
    {
        public FS.Files LlvmLibPaths;

        public static ShellEnv Empty()
        {
            var dst = new ShellEnv();
            dst.LlvmLibPaths = FS.Files.Empty;
            return dst;
        }
    }
}