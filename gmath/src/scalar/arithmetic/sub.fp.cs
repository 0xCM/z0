//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class gfp
    {

        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sub(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sub(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.sub(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                fmath.sub(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float sub(float lhs, float rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static double sub(double lhs, double rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static ref float sub(ref float lhs, float rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double sub(ref double lhs, double rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }
    }    

}