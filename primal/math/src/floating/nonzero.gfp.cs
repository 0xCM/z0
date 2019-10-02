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
        public static bool nonzero<T>(T lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return math.nonzero(float32(lhs));
            else if(typeof(T) == typeof(double))
                return math.nonzero(float64(lhs));
            else            
                throw unsupported<T>();
        }



    }

}