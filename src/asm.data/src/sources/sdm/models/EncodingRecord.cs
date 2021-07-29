//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    partial struct SdmModels
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct EncodingRecord
        {
            public uint OpCodeId;

            public EncodingCrossRef XRef;

            public EncodingExpr Operand1;

            public EncodingExpr Operand2;

            public EncodingExpr Operand3;

            public EncodingExpr Operand4;
        }
    }
}