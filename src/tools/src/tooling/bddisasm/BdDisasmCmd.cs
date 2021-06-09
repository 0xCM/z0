//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    public struct BdDisasmCmd : IToolCmd<BdDisasmCmd,BdDisasm>
    {
        public FS.FilePath ToolPath;

        public FS.FilePath BinPath;

        public Bitness Mode;

        public bool EmitBitfields;

        public bool EmitDetails;

        public bool Redirect;

        public FS.FilePath OutputFile;
    }
}