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
        public static T srl<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return srlu(src,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return srli(src,offset);
            else throw unsupported<T>();
        }

        /// <summary>
        /// Applies a logical right-shift to an integer in-place
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static ref T srl<T>(ref T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                srlu(ref lhs, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                srli(ref lhs,offset);
            else throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T srli<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.srl(int8(lhs), offset));
            if(typeof(T) == typeof(short))
                 return generic<T>(math.srl(int16(lhs), offset));
            if(typeof(T) == typeof(int))
                 return generic<T>(math.srl(int32(lhs), offset));
            else
                 return generic<T>(math.srl(int64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static T srlu<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.srl(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.srl(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.srl(uint32(lhs), offset));
            else 
                return generic<T>(math.srl(uint64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static ref T srli<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.srl(ref int8(ref lhs), rhs);
            if(typeof(T) == typeof(short))
                 math.srl(ref int16(ref lhs), rhs);
            if(typeof(T) == typeof(int))
                 math.srl(ref int32(ref lhs), rhs);
            else
                 math.srl(ref int64(ref lhs), rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T srlu<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.srl(ref uint8(ref lhs), rhs);
            if(typeof(T) == typeof(short))
                 math.srl(ref uint16(ref lhs), rhs);
            if(typeof(T) == typeof(int))
                 math.srl(ref uint32(ref lhs), rhs);
            else
                 math.srl(ref uint64(ref lhs), rhs);
            return ref lhs;
        }

    }
}