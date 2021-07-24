//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ToolchainRule
    {
        public ToolId Tool {get;}

        public FS.FilePath Input {get;}

        public CmdArgs Args {get;}

        public FS.FilePath Target {get;}

        public ToolchainRule(ToolId tool, FS.FilePath input, CmdArgs args, FS.FilePath target)
        {
            Tool = tool;
            Input = input;
            Args = args;
            Target = target;
        }
    }
}