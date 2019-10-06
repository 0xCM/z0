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
    using static AsIn;

    partial class gmath
    {


       [MethodImpl(Inline)]
        public static bool isPow2<T>(T src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return math.isPow2(int8(src));
            else if(typematch<T,byte>())
                return math.isPow2(uint8(src));
            else if(typematch<T,short>())
                return math.isPow2(int16(src));
            else if(typeof(T) == typeof(ushort))
                return math.isPow2(uint16(src));
            else if(typematch<T,int>())
                return math.isPow2(int32(src));
            else if(typeof(T) == typeof(uint))
                return math.isPow2(uint32(src));
            else if(typematch<T,long>())
                return math.isPow2(int64(src));
            else if(typeof(T) == typeof(ulong))
                return math.isPow2(uint64(src));
            else            
                throw unsupported<T>();
        }           

    }

}