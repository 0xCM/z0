//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static T inc<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return inc_u(a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return inc_i(a);
            else 
                return gfp.inc(a);
        }           

        [MethodImpl(Inline)]
        static T inc_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.inc(int8(a)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.inc(int16(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.inc(int32(a)));
            else
                 return generic<T>(math.inc(int64(a)));
        }

        [MethodImpl(Inline)]
        static T inc_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.inc(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.inc(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.inc(uint32(a)));
            else 
                return generic<T>(math.inc(uint64(a)));
        }
    }
}