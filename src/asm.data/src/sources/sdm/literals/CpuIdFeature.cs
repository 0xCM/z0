//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial struct SdmModels
    {
        [Flags]
        public enum CpuIdFeature : ulong
        {
            None = 0,

            SSE4_1,

            AVX,

            AVX2,

            AVX512F,

            AVX512BW,

            AVX512DQ,
        }
    }
}