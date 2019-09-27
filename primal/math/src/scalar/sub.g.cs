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
        /// subtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return subu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return subi(lhs,rhs);
            else return gfp.sub(lhs,rhs);
        }

        /// <summary>
        /// subtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                subu(ref lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                subi(ref lhs,rhs);
            else gfp.sub(ref lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T subi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sub(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.sub(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.sub(int32(lhs), int32(rhs)));
            else
                 return generic<T>(math.sub(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T subu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sub(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sub(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sub(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.sub(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static ref T subi<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.sub(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 math.sub(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 math.sub(ref int32(ref lhs), int32(rhs));
            else
                 math.sub(ref int64(ref lhs), int64(rhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T subu<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.sub(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                math.sub(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                math.sub(ref uint32(ref lhs), uint32(rhs));
            else 
                math.sub(ref uint64(ref lhs), uint64(rhs));
            return ref lhs;
        }
    }
}
