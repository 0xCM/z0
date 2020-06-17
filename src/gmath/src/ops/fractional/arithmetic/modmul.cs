//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 
    using static Memories;

    partial class gfp
    {
        [MethodImpl(Inline), ModMul, Closures(Floats)]
        public static T modmul<T>(T a, T b, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.modmul(float32(a), float32(b), float32(m)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.modmul(float64(a), float64(b), float64(m)));
            else
                throw Unsupported.define<T>();
        }
    }
}