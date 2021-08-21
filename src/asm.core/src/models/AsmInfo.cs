//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.llvm;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmInfo
    {
        public McAsmId Id;

        public StringAddress OpCodeExpr;

        public StringAddress SigExpr;
    }
}