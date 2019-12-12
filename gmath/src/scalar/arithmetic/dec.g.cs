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

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T dec<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return dec_u(a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return dec_i(a);
            else 
                return gfp.dec(a);
        }           

        [MethodImpl(Inline)]
        static T dec_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.dec(int8(a)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.dec(int16(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.dec(int32(a)));
            else
                 return generic<T>(math.dec(int64(a)));
        }

        [MethodImpl(Inline)]
        static T dec_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.dec(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.dec(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.dec(uint32(a)));
            else 
                return generic<T>(math.dec(uint64(a)));
        }
    }
}