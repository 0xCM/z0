//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct AsmToolchainSpec
    {
        public ToolId Assembler;

        public ToolId Disassembler;

        public FS.FilePath AsmPath;

        public FS.FilePath BinPath;

        public AsmBinKind BinKind;

        public FS.FilePath RawDisasmPath;

        public FS.FolderPath Analysis;

        public FS.FilePath ListPath;
    }
}