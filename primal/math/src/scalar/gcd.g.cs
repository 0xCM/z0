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
        public static T gcd<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return gcd_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return gcd_i(lhs,rhs);
            else 
                return gcd_f(lhs,rhs);
        }           

        [MethodImpl(Inline)]
        static T gcd_i<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((math.gcd(int8(lhs), int8(rhs))));
            else if(typeof(T) == typeof(short))
                return generic<T>((math.gcd(int16(lhs), int16(rhs))));
            else if(typeof(T) == typeof(int))
                return generic<T>((math.gcd(int32(lhs), int32(rhs))));
            else 
                return generic<T>((math.gcd(int64(lhs), int64(rhs))));
        }           

        [MethodImpl(Inline)]
        static T gcd_u<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((math.gcd(uint8(lhs), uint8(rhs))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((math.gcd(uint16(lhs), uint16(rhs))));
            else if(typeof(T) == typeof(uint))
                return generic<T>((math.gcd(uint32(lhs), uint32(rhs))));
            else 
                return generic<T>((math.gcd(uint64(lhs), uint64(rhs))));
        }           

        [MethodImpl(Inline)]
        static T gcd_f<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>((fmath.gcd(float32(lhs), float32(rhs))));
            else if(typeof(T) == typeof(double))
                return generic<T>((fmath.gcd(float64(lhs), float64(rhs))));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T gcdbin<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((math.gcdbin(uint8(lhs), uint8(rhs))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((math.gcdbin(uint16(lhs), uint16(rhs))));
            else if(typeof(T) == typeof(uint))
                return generic<T>((math.gcdbin(uint32(lhs), uint32(rhs))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>((math.gcdbin(uint64(lhs), uint64(rhs))));
            else            
                throw unsupported<T>();
        }           

   }

}