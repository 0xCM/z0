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
        public static bit eq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.eq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.eq(float64(a), float64(b));
            else            
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bit neq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.neq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.neq(float64(a), float64(b));
            else            
                throw unsupported<T>();
        }

    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static bit eq(float a, float b)
            => a == b;

        [MethodImpl(Inline)]
        public static bit eq(double a, double b)
            => a == b;

        [MethodImpl(Inline)]
        public static bit neq(float a, float b)
            => a != b;

        [MethodImpl(Inline)]
        public static bit neq(double a, double b)
            => a != b;
    }
}