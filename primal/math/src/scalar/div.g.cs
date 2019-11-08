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
        /// divtiplies two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T div<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return div_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return div_i(a,b);
            else 
                return gfp.div(a,b);
        }

        /// <summary>
        /// divtiplies two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T div<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                div_u(ref a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                div_i(ref a,b);
            else 
                gfp.div(ref a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        static T div_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.div(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.div(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.div(int32(a), int32(b)));
            else
                 return generic<T>(math.div(int64(a), int64(b)));
        }

        [MethodImpl(Inline)]
        static T div_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.div(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.div(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.div(uint32(a), uint32(b)));
            else 
                return generic<T>(math.div(uint64(a), uint64(b)));
        }

        [MethodImpl(Inline)]
        static ref T div_i<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.div(ref int8(ref a), int8(b));
            else if(typeof(T) == typeof(short))
                 math.div(ref int16(ref a), int16(b));
            else if(typeof(T) == typeof(int))
                 math.div(ref int32(ref a), int32(b));
            else
                 math.div(ref int64(ref a), int64(b));
            return ref a;
        }

        [MethodImpl(Inline)]
        static ref T div_u<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.div(ref uint8(ref a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                math.div(ref uint16(ref a), uint16(b));
            else if(typeof(T) == typeof(uint))
                math.div(ref uint32(ref a), uint32(b));
            else 
                math.div(ref uint64(ref a), uint64(b));
            return ref a;
        }
    }
}
