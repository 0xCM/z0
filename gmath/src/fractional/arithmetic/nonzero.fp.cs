//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline), Nonz, NumericClosures(NumericKind.Floats)]
        public static bit nonz<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.nonz(float32(a));
            else if(typeof(T) == typeof(double))
                return fmath.nonz(float64(a));
            else            
                throw Unsupported.define<T>();
        }
    }
}