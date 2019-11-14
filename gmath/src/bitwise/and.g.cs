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
        /// <summary>
        /// Computes the bitwise AND between two primal integers
        /// </summary>
        /// <param name="a">The left integer</param>
        /// <param name="b">The right integer</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return and_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return and_i(a,b);
            else 
                return gfp.and(a,b);
        }

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                and_u(ref a, b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                and_i(ref a, b);
            else 
                gfp.and(ref a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        static T and_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.and(int8(a), int8(b)));
            if(typeof(T) == typeof(short))
                 return generic<T>(math.and(int16(a), int16(b)));
            if(typeof(T) == typeof(int))
                 return generic<T>(math.and(int32(a), int32(b)));
            else
                 return generic<T>(math.and(int64(a), int64(b)));
        }

        [MethodImpl(Inline)]
        static T and_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.and(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.and(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.and(uint32(a), uint32(b)));
            else 
                return generic<T>(math.and(uint64(a), uint64(b)));
        }

        [MethodImpl(Inline)]
        static ref T and_i<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.and(ref int8(ref a), int8(b));
            if(typeof(T) == typeof(short))
                 math.and(ref int16(ref a), int16(b));
            if(typeof(T) == typeof(int))
                 math.and(ref int32(ref a), int32(b));
            else
                 math.and(ref int64(ref a), int64(b));
            return ref a;
        }

        [MethodImpl(Inline)]
        static ref T and_u<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.and(ref uint8(ref a), uint8(b));
            if(typeof(T) == typeof(ushort))
                 math.and(ref uint16(ref a), uint16(b));
            if(typeof(T) == typeof(uint))
                 math.and(ref uint32(ref a), uint32(b));
            else
                 math.and(ref uint64(ref a), uint64(b));
            return ref a;
        }
    }
}