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

        [MethodImpl(Inline)]
        public static ref T min<T>(ref T a, T b)
            where T : unmanaged
        {
            a = min(a,b);
            return ref a;
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

        [MethodImpl(Inline)]
        public static ref float min(ref float a, float b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double min(ref double a, double b)
        {
            a = a < b ? a : b;
            return ref a;
        }
    }    
}