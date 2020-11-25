//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    [Tool(ToolName)]
    public struct LlvmAsCmd : IToolCmd<LlvmAsCmd>
    {
        public const string ToolName = "llvm-as";

        public FS.FilePath SrcPath;

        public FS.FilePath DstPath;

        public bool PrintAssembly;

        public string DataLayout;

        public bool DisableOutput;

        public bool DisableVerify;

        public bool EnableBinaryTerminalOutput;

        public bool EmitModuleHash;

        public bool PreserveListOrder;
    }
}