//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct LlvmAsCmdInfo : IToolCmdInfo<LlvmAsCmdInfo, LlvmAsCmd>
    {
        public const string ToolName = "llvm-as";

        public static CmdOption SrcPath => Cmd.option(string.Empty, "The input file");

        public static CmdOption DstPath => Cmd.option("o", "The input file", CmdArgPrefix.Dash);

        public static CmdOption PrintAssembly => Cmd.option("d", "Print assembly as parsed", CmdArgPrefix.Dash);

        Name IToolCmdInfo<LlvmAsCmdInfo, LlvmAsCmd>.ToolName
            => ToolName;
    }
}