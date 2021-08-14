//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmOperand
    {
        public const uint SZ = PrimalSizes.U8 + PrimalSizes.U64;

        public AsmOpClass Class;

        ulong Data;
    }
}