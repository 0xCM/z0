//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T max<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.max(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.max(float64(a), float64(b)));
            else
                throw unsupported<T>();
        }        
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float max(float a, float b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static double max(double a, double b)
            => a > b ? a : b;
    }    
}