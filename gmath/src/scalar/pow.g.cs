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
        public static T pow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return pow_u(b,exp);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return pow_i(b,exp);
            else 
                return gfp.pow(b,exp);
        }

        [MethodImpl(Inline)]
        static T pow_i<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.pow(int8(b), exp));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.pow(int16(b), exp));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.pow(int32(b), exp));
            else
                 return generic<T>(math.pow(int64(b), exp));
        }

        [MethodImpl(Inline)]
        static T pow_u<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.pow(uint8(b), exp));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.pow(uint16(b), exp));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.pow(uint32(b), exp));
            else 
                return generic<T>(math.pow(uint64(b), exp));
        }
    }
}