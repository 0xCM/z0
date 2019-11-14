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
       public static T and<T>(T lhs, T rhs)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.and(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.and(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
       public static ref T and<T>(ref T lhs, T rhs)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.and(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                fmath.and(ref float64(ref lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }   
    }
}