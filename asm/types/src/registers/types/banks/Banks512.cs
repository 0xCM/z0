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
        [StructLayout(LayoutKind.Sequential, Size=1024)]
        public readonly struct Bank512x2<T> : IBank512<Bank512x2<T>,N2>
            where T : unmanaged
        {            
            readonly Vector512<T> lo;

            readonly Vector512<T> hi;
        }

        [StructLayout(LayoutKind.Sequential, Size=2048)]
        public readonly struct Bank512x4<T> : IBank512<Bank512x4<T>,N4>
            where T : unmanaged
        {            
            readonly Vector512<T> a;

            readonly Vector512<T> b;

            readonly Vector512<T> c;

            readonly Vector512<T> d;
        }        
    }
}