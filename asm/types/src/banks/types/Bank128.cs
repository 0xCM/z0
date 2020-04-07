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
        [StructLayout(LayoutKind.Sequential, Size=256)]
        public readonly struct Bank128x2<T> : IBank128<Bank128x2<T>,N2>
            where T : unmanaged
        {            
            readonly Vector128<T> lo;

            readonly Vector128<T> hi;
        }

        [StructLayout(LayoutKind.Sequential, Size=512)]
        public readonly struct Bank128x4<T> : IBank128<Bank128x4<T>,N4>
            where T : unmanaged
        {            
            readonly Vector128<T> a;

            readonly Vector128<T> b;

            readonly Vector128<T> c;

            readonly Vector128<T> d;
        }
    }
}