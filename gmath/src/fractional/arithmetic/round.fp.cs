//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class gfp
    {
        [MethodImpl(Inline), Closures(NumericKind.Floats)]
        public static T round<T>(T src, int scale)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.round(float32(src), scale));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.round(float64(src), scale));
            else
                return src;
        }
    }

}