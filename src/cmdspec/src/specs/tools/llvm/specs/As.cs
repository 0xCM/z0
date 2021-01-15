//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    partial struct Llvm
    {
        [Tool]
        public readonly struct As : ITool<As>
        {
            public Name ToolName => ToolNames.@as;
        }

        [Cmd]
        public struct AsCmd : IToolCmd<AsCmd,As>
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