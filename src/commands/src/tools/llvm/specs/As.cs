//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    partial struct Llvm
    {
        public struct As : ITool<As>
        {
            public string ToolName => ToolNames.@as;
        }

        [Tool]
        public struct AsCmd : IToolCmd<As,AsCmd>
        {
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
}