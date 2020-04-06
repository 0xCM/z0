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
        public readonly struct Bank64x16 : IBank64<Bank64x16,N16>
        {            
            readonly Vector256<ulong> a;

            readonly Vector256<ulong> b;

            readonly Vector256<ulong> c;

            readonly Vector256<ulong> d;
        }

    }
}