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
        /// mintiplies two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T min<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return min_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return min_i(a,b);
            else 
                return gfp.min(a,b);
        }

        /// <summary>
        /// mintiplies two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T min<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return ref min_u(ref a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return ref min_i(ref a,b);
            else 
                return ref gfp.min(ref a,b);
        }

        [MethodImpl(Inline)]
        static T min_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.min(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.min(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.min(int32(a), int32(b)));
            else
                 return generic<T>(math.min(int64(a), int64(b)));
        }

        [MethodImpl(Inline)]
        static T min_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.min(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.min(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.min(uint32(a), uint32(b)));
            else 
                return generic<T>(math.min(uint64(a), uint64(b)));
        }

        [MethodImpl(Inline)]
        static ref T min_i<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.min(ref int8(ref a), int8(b));
            else if(typeof(T) == typeof(short))
                 math.min(ref int16(ref a), int16(b));
            else if(typeof(T) == typeof(int))
                 math.min(ref int32(ref a), int32(b));
            else
                 math.min(ref int64(ref a), int64(b));
            return ref a;
        }

        [MethodImpl(Inline)]
        static ref T min_u<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.min(ref uint8(ref a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                math.min(ref uint16(ref a), uint16(b));
            else if(typeof(T) == typeof(uint))
                math.min(ref uint32(ref a), uint32(b));
            else 
                math.min(ref uint64(ref a), uint64(b));
            return ref a;
        }
    }
}
