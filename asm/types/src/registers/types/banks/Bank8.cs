//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using specs = AsmSpecs;
    

    partial class Banks
    {
        public readonly struct Bank8x16 : IBank8<Bank8x16,N16>
        {
            readonly Vector128<byte> state;
        }

        public readonly struct Bank8x32 : IBank8<Bank8x32,N32>
        {
            readonly Vector256<byte> state;
        }

    }
}