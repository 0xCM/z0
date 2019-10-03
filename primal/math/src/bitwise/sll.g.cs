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
        /// Applies a logical right-shift to an integer
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static T sll<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return sllu(src,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return slli(src,offset);
            else throw unsupported<T>();
        }

        /// <summary>
        /// Applies a logical right-shift to an integer in-place
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sll<T>(ref T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                sllu(ref lhs, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                slli(ref lhs,offset);
            else throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T slli<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sll(int8(lhs), offset));
            if(typeof(T) == typeof(short))
                 return generic<T>(math.sll(int16(lhs), offset));
            if(typeof(T) == typeof(int))
                 return generic<T>(math.sll(int32(lhs), offset));
            else
                 return generic<T>(math.sll(int64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static T sllu<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sll(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sll(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sll(uint32(lhs), offset));
            else 
                return generic<T>(math.sll(uint64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static ref T slli<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.sll(ref int8(ref lhs), rhs);
            if(typeof(T) == typeof(short))
                 math.sll(ref int16(ref lhs), rhs);
            if(typeof(T) == typeof(int))
                 math.sll(ref int32(ref lhs), rhs);
            else
                 math.sll(ref int64(ref lhs), rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T sllu<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.sll(ref uint8(ref lhs), rhs);
            if(typeof(T) == typeof(short))
                 math.sll(ref uint16(ref lhs), rhs);
            if(typeof(T) == typeof(int))
                 math.sll(ref uint32(ref lhs), rhs);
            else
                 math.sll(ref uint64(ref lhs), rhs);
            return ref lhs;
        }

    }
}