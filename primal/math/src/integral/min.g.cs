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

    partial class gmath
    {

        [MethodImpl(Inline)]
        public static T min<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>((Math.Min(int8(lhs), int8(rhs))));
            else if(typematch<T,byte>())
                return generic<T>((Math.Min(uint8(lhs), uint8(rhs))));
            else if(typematch<T,short>())
                return generic<T>((Math.Min(int16(lhs), int16(rhs))));
            else if(typematch<T,ushort>())
                return generic<T>((Math.Min(uint16(lhs), uint16(rhs))));
            else if(typematch<T,int>())
                return generic<T>((Math.Min(int32(lhs), int32(rhs))));
            else if(typematch<T,uint>())
                return generic<T>((Math.Min(uint32(lhs), uint32(rhs))));
            else if(typematch<T,long>())
                return generic<T>((Math.Min(int64(lhs), int64(rhs))));
            else if(typematch<T,ulong>())
                return generic<T>((Math.Min(uint64(lhs), uint64(rhs))));
            else if(typematch<T,float>())
             return generic<T>((MathF.Min(float32(lhs), float32(rhs))));
          else if(typematch<T,double>())
             return generic<T>((Math.Min(float64(lhs), float64(rhs))));
            else            
                throw unsupported<T>();
        }           
 
        [MethodImpl(Inline)]
        public static T min<T>(in T lhs, in T rhs)
            where T : struct
                => min(lhs,rhs);

    }
}