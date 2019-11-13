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
        public static bool divides<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.divides(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.divides(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }
    }
}