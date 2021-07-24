//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial struct Llvm
    {
        [Tool]
        public readonly struct As : ITool<As>
        {
            public ToolId Id => Toolspace.llvm_as;
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