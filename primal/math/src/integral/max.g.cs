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
        public static T max<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>((math.max(int8(lhs), int8(rhs))));
            else if(typematch<T,byte>())
                return generic<T>((math.max(uint8(lhs), uint8(rhs))));
            else if(typematch<T,short>())
                return generic<T>((math.max(int16(lhs), int16(rhs))));
            else if(typematch<T,ushort>())
                return generic<T>((math.max(uint16(lhs), uint16(rhs))));
            else if(typematch<T,int>())
                return generic<T>((math.max(int32(lhs), int32(rhs))));
            else if(typematch<T,uint>())
                return generic<T>((math.max(uint32(lhs), uint32(rhs))));
            else if(typematch<T,long>())
                return generic<T>((math.max(int64(lhs), int64(rhs))));
            else if(typematch<T,ulong>())
                return generic<T>((math.max(uint64(lhs), uint64(rhs))));
            else if(typematch<T,float>())
                return generic<T>((math.max(float32(lhs), float32(rhs))));
            else if(typematch<T,double>())
                return generic<T>((math.max(float64(lhs), float64(rhs))));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T max<T>(in T lhs, in T rhs)
            where T : struct
                => max(lhs,rhs);


    }

}