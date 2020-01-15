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
       [MethodImpl(Inline), Op]
       public static T or<T>(T a, T b)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.or(float32(a), float32(b)));
            else if(typeof(T) == typeof(float))
                return generic<T>(fmath.or(float64(a), float64(b)));
            else
                throw unsupported<T>();
        }
    }

    partial class fmath
    {
        [MethodImpl(Inline), Op]
        public static float or(float a, float b)
            => BitConvert.ToSingle(a.ToBits() | b.ToBits());

        [MethodImpl(Inline), Op]
        public static double or(double a, double b)
            => BitConvert.ToDouble(a.ToBits() | b.ToBits());         
    }
}