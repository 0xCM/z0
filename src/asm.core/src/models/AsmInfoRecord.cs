//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static llvm.MC;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmInfoRecord
    {
        public AsmId Id;

        public CharBlock32 OpCodeExpr;

        public CharBlock32 SigExpr;
    }
}