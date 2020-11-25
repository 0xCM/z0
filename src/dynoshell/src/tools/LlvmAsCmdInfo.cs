//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    public struct LlvmAsCmdInfo : IToolCmdInfo<LlvmAsCmdInfo, LlvmAsCmd>
    {
        public const string ToolName = "llvm-as";

        public static CmdOptionSpec SrcPath => Cmd.option(string.Empty, "The input file");

        public static CmdOptionSpec DstPath => Cmd.option("o", "The input file", CmdArgPrefix.Dash);

        public static CmdOptionSpec PrintAssembly => Cmd.option("d", "Print assembly as parsed", CmdArgPrefix.Dash);

        Name IToolCmdInfo<LlvmAsCmdInfo, LlvmAsCmd>.ToolName
            => ToolName;
    }
}