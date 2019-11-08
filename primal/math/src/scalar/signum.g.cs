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
        /// Computes the sign of a primal operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Sign signum<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return signum_u<T>(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return signum_i<T>(src);
            else 
                return signum_f<T>(src);
        }           

        [MethodImpl(Inline)]
        static Sign signum_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.signum(int8(src));
            else if(typeof(T) == typeof(short))
                return math.signum(int16(src));
            else if(typeof(T) == typeof(uint))
                return math.signum(uint32(src));
            else 
                return math.signum(int64(src));
        }        

        [MethodImpl(Inline)]
        static Sign signum_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.signum(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return math.signum(uint16(src));
            else if(typeof(T) == typeof(uint))
                return math.signum(uint32(src));
            else 
                return math.signum(uint64(src));
       }           

        [MethodImpl(Inline)]
        static Sign signum_f<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.signum(float32(src));
            else if(typeof(T) == typeof(double))
                return fmath.signum(float64(src));
            else            
                throw unsupported<T>();
        }           
    }
}