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
       [MethodImpl(Inline)]
       public static T and<T>(T a, T b)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.and(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.and(float64(a), float64(b)));
            else
                throw unsupported<T>();
        }
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float and(float a, float b)
            => BitConvert.ToSingle(a.ToBits() &  b.ToBits());

        [MethodImpl(Inline)]
        public static double and(double a, double b)
            => BitConvert.ToDouble(a.ToBits() &  b.ToBits());
    }    
}