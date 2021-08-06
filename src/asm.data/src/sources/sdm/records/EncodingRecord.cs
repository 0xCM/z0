//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    using static SdmModels;

    partial struct SdmRecords
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct EncodingRecord
        {
            public EncodingCrossRef XRef;

            public OpEncodingSpec Operand1;

            public OpEncodingSpec Operand2;

            public OpEncodingSpec Operand3;

            public OpEncodingSpec Operand4;
        }
    }
}