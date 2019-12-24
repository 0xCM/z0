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
        public static bit within<T>(T lhs, T rhs, T epsilon)    
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.within(float32(lhs),float32(rhs), float32(epsilon));
            else if(typeof(T) == typeof(double))
                return fmath.within(float64(lhs), float64(rhs), float64(epsilon));
            else            
                throw unsupported<T>();
        }        
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static bit within(float lhs, float rhs, float epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bit within(double lhs, double rhs, double epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;
    }

}