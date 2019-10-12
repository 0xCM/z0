//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {        
        [MethodImpl(Inline)]
        public static T xor1<T>(T a)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.xor1(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xor1(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xor1(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xor1(uint64(a)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the XOR of two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return xor_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return xor_i(lhs,rhs);
            else 
                return gfp.xor(lhs,rhs);
        }

        /// <summary>
        /// Computes the XOR of two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                xor_u(ref lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                xor_i(ref lhs,rhs);
            else 
                gfp.xor(ref lhs,rhs);
            
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T xor_i<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.xor(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.xor(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.xor(int32(lhs), int32(rhs)));
            else
                 return generic<T>(math.xor(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T xor_u<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.xor(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xor(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xor(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.xor(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static ref T xor_i<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.xor(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 math.xor(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 math.xor(ref int32(ref lhs), int32(rhs));
            else
                 math.xor(ref int64(ref lhs), int64(rhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T xor_u<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.xor(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(ref uint32(ref lhs), uint32(rhs));
            else 
                math.xor(ref uint64(ref lhs), uint64(rhs));
            return ref lhs;
        }
    }
}
