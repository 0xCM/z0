//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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

       [MethodImpl(Inline)]
       public static ref T and<T>(ref T a, T b)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.and(ref float32(ref a), float32(b));
            else if(typeof(T) == typeof(double))
                fmath.and(ref float64(ref a), float64(b));
            else
                throw unsupported<T>();
            return ref a;
        }   
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static ref float and(ref float a, float b)
        {
            a = and(a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double and(ref double a, double b)
        {
            a = and(a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static float and(float a, float b)
            => BitConvert.ToSingle(a.ToBits() &  b.ToBits());

        [MethodImpl(Inline)]
        public static double and(double a, double b)
            => BitConvert.ToDouble(a.ToBits() &  b.ToBits());
    }    
}