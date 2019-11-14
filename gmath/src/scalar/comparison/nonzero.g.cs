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
        public static bit nonzero<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return nonzerou(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return nonzeroi(src);
            else return gfp.nonzero(src);
        }

        [MethodImpl(Inline)]
        static bit nonzerou<T>(T src)
        {
            if(typeof(T) == typeof(byte))
                 return math.nonzero(uint8(src));
            else if(typeof(T) == typeof(ushort))
                 return math.nonzero(uint16(src));
            else if(typeof(T) == typeof(uint))
                 return math.nonzero(uint32(src));
            else
                 return math.nonzero(uint64(src));
        }

        [MethodImpl(Inline)]
        static bit nonzeroi<T>(T src)
        {
            if(typeof(T) == typeof(sbyte))
                 return math.nonzero(int8(src));
            else if(typeof(T) == typeof(short))
                 return math.nonzero(int16(src));
            else if(typeof(T) == typeof(int))
                 return math.nonzero(int32(src));
            else
                 return math.nonzero(int64(src));
        }
    }

}