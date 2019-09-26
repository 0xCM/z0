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
        public static bool eq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,float>())
                 return fmath.eq(float32(lhs), float32(rhs));
            else if(typematch<T,double>())
                 return fmath.eq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,float>())
                 return fmath.lt(float32(lhs), float32(rhs));
            else if(typematch<T,double>())
                 return fmath.lt(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,float>())
                 return fmath.lteq(float32(lhs), float32(rhs));
            else if(typematch<T,double>())
                 return fmath.lteq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }



        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,float>())
                 return !fmath.eq(float32(lhs), float32(rhs));
            else if(typematch<T,double>())
                 return !fmath.eq(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

    }

}