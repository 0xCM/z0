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
        /// <summary>
        /// addtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return addu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return addi(lhs,rhs);
            else 
                return gfp.add(lhs,rhs);
        }

        /// <summary>
        /// addtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                addu(ref lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                addi(ref lhs,rhs);
            else gfp.add(ref lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T addi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.add(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.add(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.add(int32(lhs), int32(rhs)));
            else
                 return generic<T>(math.add(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T addu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.add(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.add(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.add(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.add(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static ref T addi<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.add(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 math.add(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 math.add(ref int32(ref lhs), int32(rhs));
            else
                 math.add(ref int64(ref lhs), int64(rhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T addu<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.add(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                math.add(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                math.add(ref uint32(ref lhs), uint32(rhs));
            else 
                math.add(ref uint64(ref lhs), uint64(rhs));
            return ref lhs;
        }
    }
}
