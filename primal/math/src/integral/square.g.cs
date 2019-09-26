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
        public static T square<T>(T src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.square(int8(src)));
            else if(typematch<T,byte>())
                return generic<T>(math.square(uint8(src)));
            else if(typematch<T,short>())
                return generic<T>(math.square(int16(src)));
            else if(typematch<T,ushort>())
                return generic<T>(math.square(uint16(src)));
            else if(typematch<T,int>())
                return generic<T>(math.square(int32(src)));
            else if(typematch<T,uint>())
                return generic<T>(math.square(uint32(src)));
            else if(typematch<T,long>())
                return generic<T>(math.square(int64(src)));
            else if(typematch<T,ulong>())
                return generic<T>(math.square(uint64(src)));
            else if(typematch<T,float>())
                return generic<T>(math.square(float32(src)));
            else if(typematch<T,double>())
                return generic<T>(math.square(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T square<T>(ref T src)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.square(ref int8(ref src));
            else if(typematch<T,byte>())
                math.square(ref uint8(ref src));
            else if(typematch<T,short>())
                math.square(ref int16(ref src));
            else if(typematch<T,ushort>())
                math.square(ref uint16(ref src));
            else if(typematch<T,int>())
                math.square(ref int32(ref src));
            else if(typematch<T,uint>())
                math.square(ref uint32(ref src));
            else if(typematch<T,long>())
                math.square(ref int64(ref src));
            else if(typematch<T,ulong>())
                math.square(ref uint64(ref src));
            else if(typematch<T,float>())
                math.square(ref float32(ref src));
            else if(typematch<T,double>())
                math.square(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           


    }
}