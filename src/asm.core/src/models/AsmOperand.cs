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
        public const uint SZ = 2*PrimalSizes.U8;

        public AsmOpClass Class;

        public AsmSizeKind Size;
    }
}