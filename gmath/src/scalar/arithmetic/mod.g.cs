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
        /// <summary>
        /// modtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return mod_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return mod_i(lhs,rhs);
            else 
                return gfp.mod(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static T mod_i<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.mod(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.mod(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.mod(int32(lhs), int32(rhs)));
            else
                 return generic<T>(math.mod(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T mod_u<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.mod(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.mod(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mod(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.mod(uint64(lhs), uint64(rhs)));
        }
    }
}
