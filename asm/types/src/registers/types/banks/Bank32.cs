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
        public readonly struct Bank32x16 : IBank32<Bank32x16,N16>
        {            
            readonly Vector256<uint> lo;


            readonly Vector256<uint> hi;
        }

        public readonly struct Bank32x32 : IBank32<Bank32x32,N32>
        {            
            readonly Vector256<uint> a;

            readonly Vector256<uint> b;

            readonly Vector256<uint> c;

            readonly Vector256<uint> d;
        }
    }
}