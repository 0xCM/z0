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
                return not_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return not_i(src);
            else throw unsupported<T>();
        }           


        [MethodImpl(Inline)]
        static T not_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.not(int8(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.not(int16(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.not(int32(src)));
            else
                 return generic<T>(math.not(int64(src)));
        }

        [MethodImpl(Inline)]
        static T not_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.not(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.not(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.not(uint32(src)));
            else 
                return generic<T>(math.not(uint64(src)));
        }
    }
}