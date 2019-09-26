//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,float>())
                 return fmath.gt(float32(lhs), float32(rhs));
            else if(typematch<T,double>())
                 return fmath.gt(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,float>())
                 return fmath.gteq(float32(lhs), float32(rhs));
            else if(typematch<T,double>())
                 return fmath.gteq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }



    }

}