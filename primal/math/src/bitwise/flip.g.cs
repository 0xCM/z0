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
        /// If the source value is signed, flips it; otherwise, computes
        /// the two's complement negation
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static T not<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return flip_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return flip_i(src);
            else throw unsupported<T>();
        }           

        /// <summary>
        /// If the source value is signed, flips it in-place; otherwise, computes
        /// the two's complement negation in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static ref T not<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                flip_u(ref src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                flip_i(ref src);
            else throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        static T flip_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.flip(int8(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.flip(int16(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.flip(int32(src)));
            else
                 return generic<T>(math.flip(int64(src)));
        }

        [MethodImpl(Inline)]
        static T flip_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.not(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.flip(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.flip(uint32(src)));
            else 
                return generic<T>(math.flip(uint64(src)));
        }

        [MethodImpl(Inline)]
        static ref T flip_i<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 math.flip(ref int8(ref src));
            else if(typeof(T) == typeof(short))
                 math.flip(ref int16(ref src));
            else if(typeof(T) == typeof(int))
                 math.flip(ref int32(ref src));
            else
                 math.flip(ref int64(ref src));
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T flip_u<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.flip(ref uint8(ref src));
            else if(typeof(T) == typeof(ushort))
                 math.flip(ref uint16(ref src));
            else if(typeof(T) == typeof(uint))
                 math.flip(ref uint32(ref src));
            else
                 math.flip(ref uint64(ref src));
            return ref src;
        }
    }
}