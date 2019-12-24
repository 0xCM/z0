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
        public static T max<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.max(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.max(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }        

        [MethodImpl(Inline)]
        public static ref T max<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.max(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                fmath.max(ref float64(ref lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }        
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float max(float lhs, float rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double max(double lhs, double rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ref float max(ref float lhs, float rhs)
        {
            lhs = lhs > rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double max(ref double lhs, double rhs)
        {
            lhs = lhs > rhs ? lhs : rhs;
            return ref lhs;
        }
    }    
}