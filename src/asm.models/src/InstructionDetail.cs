//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct InstructionDetail
    {
        readonly Vector256<byte> Data;

        internal InstructionDetail(Vector256<byte> src)
        {
            Data = src;
        }
    }
}