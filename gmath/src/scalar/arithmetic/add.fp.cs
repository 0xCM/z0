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
        public static T add<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.add(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.add(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.add(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                fmath.add(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static ref float add(ref float lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double add(ref double lhs, double rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static float add(float lhs, float rhs, out float dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs, out double dst)
            => dst = lhs + rhs;


    }

}