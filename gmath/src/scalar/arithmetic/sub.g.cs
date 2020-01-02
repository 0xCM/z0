//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Subtracts the right value from the left
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sub<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return sub_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return sub_i(a,b);
            else 
                return gfp.sub(a,b);
        }

        [MethodImpl(Inline)]
        static T sub_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.sub(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.sub(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.sub(int32(a), int32(b)));
            else
                 return generic<T>(math.sub(int64(a), int64(b)));
        }

        [MethodImpl(Inline)]
        static T sub_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.sub(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sub(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sub(uint32(a), uint32(b)));
            else 
                return generic<T>(math.sub(uint64(a), uint64(b)));
        }
    }
}
