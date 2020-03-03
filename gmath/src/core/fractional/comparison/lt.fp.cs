//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bit lt<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.lt(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.lt(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bit lteq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.lteq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.lteq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }


    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static bit lt(float lhs, float rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(double lhs, double rhs)
            => lhs < rhs;        

        [MethodImpl(Inline)]
        public static bit lteq(float lhs, float rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(double lhs, double rhs)
            => lhs <= rhs;        

    }


}