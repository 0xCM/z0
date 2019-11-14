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
        public static ref T pow<T>(ref T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                pow_u(ref b, exp);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                pow_i(ref b,exp);
            else 
                gfp.pow(ref b,exp);
            
            return ref b;
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

        [MethodImpl(Inline)]
        static ref T pow_i<T>(ref T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.pow(ref int8(ref b), exp);
            else if(typeof(T) == typeof(short))
                 math.pow(ref int16(ref b), exp);
            else if(typeof(T) == typeof(int))
                 math.pow(ref int32(ref b), exp);
            else
                 math.pow(ref int64(ref b), exp);
            return ref b;
        }

        [MethodImpl(Inline)]
        static ref T pow_u<T>(ref T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.pow(ref uint8(ref b), exp);
            else if(typeof(T) == typeof(short))
                 math.pow(ref uint16(ref b), exp);
            else if(typeof(T) == typeof(int))
                 math.pow(ref uint32(ref b), exp);
            else
                 math.pow(ref uint64(ref b), exp);
            return ref b;
        }

    }
}