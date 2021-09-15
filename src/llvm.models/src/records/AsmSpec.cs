//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmSpec
    {
        public const string TableId = "llvm.asmSpec";

        public AsmId Id;

        public byte Size;

        public bit IsReturn;

        public bit IsBranch;

        public bit IsCompare;

        public bit IsMoveImm;

        public bit IsMoveReg;

        public bit IsCall;

        public bit IsPseudo;

        public StringAddress AsmString;
    }
}