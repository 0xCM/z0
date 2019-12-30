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
        /// Applies a logical left-shift to an integer
        /// </summary>
        /// <param name="a">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static T sll<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return sll_u(a,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return sll_i(a,offset);
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static T sll_i<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sll(int8(a), offset));
            if(typeof(T) == typeof(short))
                 return generic<T>(math.sll(int16(a), offset));
            if(typeof(T) == typeof(int))
                 return generic<T>(math.sll(int32(a), offset));
            else
                 return generic<T>(math.sll(int64(a), offset));
        }

        [MethodImpl(Inline)]
        static T sll_u<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sll(uint8(a), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sll(uint16(a), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sll(uint32(a), offset));
            else 
                return generic<T>(math.sll(uint64(a), offset));
        }

    }
}