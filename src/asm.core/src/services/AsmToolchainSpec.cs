//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct AsmToolchainSpec
    {
        public ToolId Assembler;

        public ToolId Disassembler;

        public FS.FilePath AsmPath;

        public FS.FilePath BinPath;

        public FS.FilePath DisasmPath;

        public FS.FolderPath Analysis;
    }
}