//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Floats)]
        public static T min<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.min(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.min(float64(a), float64(b)));
            else
                throw unsupported<T>();
        }        
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float min(float a, float b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static double min(double a, double b)
            => a < b ? a : b;
    }    
}