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
            if(typematch<T,sbyte>())
                return generic<T>((math.gcd(int8(lhs), int8(rhs))));
            else if(typematch<T,byte>())
                return generic<T>((math.gcd(uint8(lhs), uint8(rhs))));
            else if(typematch<T,short>())
                return generic<T>((math.gcd(int16(lhs), int16(rhs))));
            else if(typematch<T,ushort>())
                return generic<T>((math.gcd(uint16(lhs), uint16(rhs))));
            else if(typematch<T,int>())
                return generic<T>((math.gcd(int32(lhs), int32(rhs))));
            else if(typematch<T,uint>())
                return generic<T>((math.gcd(uint32(lhs), uint32(rhs))));
            else if(typematch<T,long>())
                return generic<T>((math.gcd(int64(lhs), int64(rhs))));
            else if(typematch<T,ulong>())
                return generic<T>((math.gcd(uint64(lhs), uint64(rhs))));
            else if(typeof(T) == typeof(float))
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
            else if(typematch<T,ushort>())
                return generic<T>((math.gcdbin(uint16(lhs), uint16(rhs))));
            else if(typematch<T,uint>())
                return generic<T>((math.gcdbin(uint32(lhs), uint32(rhs))));
            else if(typematch<T,ulong>())
                return generic<T>((math.gcdbin(uint64(lhs), uint64(rhs))));
            else            
                throw unsupported<T>();
        }           

   }

}