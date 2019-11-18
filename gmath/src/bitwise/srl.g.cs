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
        /// <param name="a">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static T srl<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return srl_u(a,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return srl_i(a,offset);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Applies a logical right-shift to an integer in-place
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static ref T srl<T>(ref T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                srl_u(ref a, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                srl_i(ref a,offset);
            else 
                throw unsupported<T>();
            return ref a;
        }

        [MethodImpl(Inline)]
        static T srl_i<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.srl(int8(a), offset));
            if(typeof(T) == typeof(short))
                 return generic<T>(math.srl(int16(a), offset));
            if(typeof(T) == typeof(int))
                 return generic<T>(math.srl(int32(a), offset));
            else
                 return generic<T>(math.srl(int64(a), offset));
        }

        [MethodImpl(Inline)]
        static T srl_u<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.srl(uint8(a), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.srl(uint16(a), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.srl(uint32(a), offset));
            else 
                return generic<T>(math.srl(uint64(a), offset));
        }

        [MethodImpl(Inline)]
        static ref T srl_i<T>(ref T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.srl(ref int8(ref a), offset);
            if(typeof(T) == typeof(short))
                 math.srl(ref int16(ref a), offset);
            if(typeof(T) == typeof(int))
                 math.srl(ref int32(ref a), offset);
            else
                 math.srl(ref int64(ref a), offset);
            return ref a;
        }

        [MethodImpl(Inline)]
        static ref T srl_u<T>(ref T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.srl(ref uint8(ref a), offset);
            if(typeof(T) == typeof(short))
                 math.srl(ref uint16(ref a), offset);
            if(typeof(T) == typeof(int))
                 math.srl(ref uint32(ref a), offset);
            else
                 math.srl(ref uint64(ref a), offset);
            return ref a;
        }

    }
}