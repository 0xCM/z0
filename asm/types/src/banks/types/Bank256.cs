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
        [StructLayout(LayoutKind.Sequential, Size=512)]
        public readonly struct Bank256x2<T> : IBank256<Bank256x2<T>,N2>
            where T : unmanaged
        {            
            readonly Vector256<T> lo;

            readonly Vector256<T> hi;

        }

        [StructLayout(LayoutKind.Sequential, Size=1024)]
        public readonly struct Bank256x4<T> : IBank256<Bank256x4<T>,N4>
            where T : unmanaged
        {            
            readonly Vector256<T> a;

            readonly Vector256<T> b;

            readonly Vector256<T> c;

            readonly Vector256<T> d;

        }
    }
}