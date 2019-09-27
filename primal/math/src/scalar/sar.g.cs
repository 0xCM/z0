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
        /// Applies an arithmetic left-shift to an integer
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static T sar<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return saru(src,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return sari(src,offset);
            else throw unsupported<T>();
        }

        /// <summary>
        /// Applies an arithmetic left-shift to an integer in-place
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sar<T>(ref T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                saru(ref lhs, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                sari(ref lhs,offset);
            else throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T sari<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sar(int8(lhs), offset));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.sar(int16(lhs), offset));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.sar(int32(lhs), offset));
            else
                 return generic<T>(math.sar(int64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static T saru<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sar(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sar(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sar(uint32(lhs), offset));
            else 
                return generic<T>(math.sar(uint64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static ref T sari<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.sar(ref int8(ref lhs), rhs);
            else if(typeof(T) == typeof(short))
                 math.sar(ref int16(ref lhs), rhs);
            else if(typeof(T) == typeof(int))
                 math.sar(ref int32(ref lhs), rhs);
            else
                 math.sar(ref int64(ref lhs), rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T saru<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.sar(ref uint8(ref lhs), rhs);
            else if(typeof(T) == typeof(short))
                 math.sar(ref uint16(ref lhs), rhs);
            else if(typeof(T) == typeof(int))
                 math.sar(ref uint32(ref lhs), rhs);
            else
                 math.sar(ref uint64(ref lhs), rhs);
            return ref lhs;
        }

    }
}