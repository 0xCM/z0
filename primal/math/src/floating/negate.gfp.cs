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
        public static T negate<T>(T lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.negate(float32(lhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.negate(float64(lhs)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T negate<T>(ref T lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.negate(ref float32(ref lhs));
            else if(typeof(T) == typeof(double))
                fmath.negate(ref float64(ref lhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }

}