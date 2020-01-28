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
        public static T mul<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.mul(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.mul(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }
    }

    partial class fmath
    {
        [MethodImpl(Inline), Op]
        public static float mul(float lhs, float rhs)
            => lhs * rhs;

        [MethodImpl(Inline), Op]
        public static double mul(double lhs, double rhs)
            => lhs * rhs;
    }
}