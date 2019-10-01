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
        public static T sal<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return salu(src,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return sali(src,offset);
            else throw unsupported<T>();
        }

        /// <summary>
        /// Applies an arithmetic left-shift to an integer in-place
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sal<T>(ref T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                salu(ref lhs, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                sali(ref lhs,offset);
            else throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T sali<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sal(int8(lhs), offset));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.sal(int16(lhs), offset));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.sal(int32(lhs), offset));
            else
                 return generic<T>(math.sal(int64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static T salu<T>(T lhs, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sal(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sal(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sal(uint32(lhs), offset));
            else 
                return generic<T>(math.sal(uint64(lhs), offset));
        }

        [MethodImpl(Inline)]
        static ref T sali<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.sal(ref int8(ref lhs), rhs);
            else if(typeof(T) == typeof(short))
                 math.sal(ref int16(ref lhs), rhs);
            else if(typeof(T) == typeof(int))
                 math.sal(ref int32(ref lhs), rhs);
            else
                 math.sal(ref int64(ref lhs), rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T salu<T>(ref T lhs, int rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.sal(ref uint8(ref lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                 math.sal(ref uint16(ref lhs), rhs);
            else if(typeof(T) == typeof(uint))
                 math.sal(ref uint32(ref lhs), rhs);
            else
                 math.sal(ref uint64(ref lhs), rhs);
            return ref lhs;
        }

    }
}