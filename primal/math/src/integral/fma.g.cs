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
        public static T fma<T>(T x, T y, T z)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.fma(int8(x), int8(y), int8(z)));
            else if(typematch<T,byte>())
                return generic<T>(math.fma(uint8(x), uint8(y), uint8(z)));
            else if(typematch<T,short>())
                return generic<T>(math.fma(int16(x), int16(y), int16(z)));
            else if(typematch<T,ushort>())
                return generic<T>(math.fma(uint16(x), uint16(y), uint16(z)));
            else if(typematch<T,int>())
                return generic<T>(math.fma(int32(x), int32(y), int32(z)));
            else if(typematch<T,uint>())
                return generic<T>(math.fma(uint32(x), uint32(y), uint32(z)));
            else if(typematch<T,long>())
                return generic<T>(math.fma(int64(x), int64(y), int64(z)));
            else if(typematch<T,ulong>())
                return generic<T>(math.fma(uint64(x), uint64(y), uint64(z)));
            else if(typematch<T,float>())
                return generic<T>(fmath.fma(float32(x), float32(y), float32(z)));
            else if(typematch<T,double>())
                return generic<T>(fmath.fma(float64(x), float64(y), float64(z)));
            else            
                throw unsupported<T>();
        }

    }

}