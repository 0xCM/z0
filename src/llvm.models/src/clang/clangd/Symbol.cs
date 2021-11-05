//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang.clangd
{
    using System.Runtime.InteropServices;

    public struct Symbol
    {
        public Hash32 Id;

        public index.SymbolInfo SymInfo;

    }
}