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
        public static bool eq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.eq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.eq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.neq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.neq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static bool eq(float lhs, float rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(double lhs, double rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool neq(float lhs, float rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(double lhs, double rhs)
            => lhs != rhs;
    }
}