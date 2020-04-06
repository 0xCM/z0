//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    
    partial class Banks
    {
        public readonly struct Bank16x16 : IBank16<Bank16x16,N16>
        {
            readonly Vector256<ushort> state;

        }

        public readonly struct Bank16x32 : IBank16<Bank16x32,N32>
        {
            readonly Vector256<ushort> lo;

            readonly Vector256<ushort> hi;
        }
    }
}