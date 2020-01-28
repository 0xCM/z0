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

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Floats)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.gt(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.gt(float64(a), float64(b));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Floats)]
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.gteq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.gteq(float64(a), float64(b));
            else            
                throw unsupported<T>();
        }
    }

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static bit gt(float a, float b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(double a, double b)
            => a > b;        

        [MethodImpl(Inline)]
        public static bit gteq(float a, float b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bit gteq(double a, double b)
            => a >= b;        
    }    
}