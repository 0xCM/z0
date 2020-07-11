//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 
    using static z;

    partial class gfp
    {
        [MethodImpl(Inline), Lt, Closures(NumericKind.Floats)]
        public static bit lt<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.lt(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.lt(float64(lhs), float64(rhs));
            else            
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline), LtEq, Closures(NumericKind.Floats)]
        public static bit lteq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.lteq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.lteq(float64(lhs), float64(rhs));
            else            
                throw Unsupported.define<T>();
        }
    }
}