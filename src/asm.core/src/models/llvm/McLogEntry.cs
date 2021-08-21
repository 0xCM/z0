//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.InteropServices;

    using Z0.Asm;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct McLogEntry
    {
        public FS.FilePath AsmSrcFile;

        public AsmExpr Statement;
    }
}