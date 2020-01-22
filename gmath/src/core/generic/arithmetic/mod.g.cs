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
        /// Computes b := a % m
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="m">The modulus</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T mod<T>(T a, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return mod_u(a,m);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return mod_i(a,m);
            else 
                return gfp.mod(a,m);
        }

        [MethodImpl(Inline)]
        static T mod_i<T>(T a, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.mod(convert<T,int>(a), convert<T,int>(m)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.mod(convert<T,int>(a), convert<T,int>(m)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.mod(int32(a), int32(m)));
            else
                 return generic<T>(math.mod(int64(a), int64(m)));
        }

        [MethodImpl(Inline)]
        static T mod_u<T>(T a, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.mod(convert<T,uint>(a), convert<T,uint>(m)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.mod(convert<T,uint>(a), convert<T,uint>(m)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mod(uint32(a), uint32(m)));
            else 
                return generic<T>(math.mod(uint64(a), uint64(m)));
        }
    }
}
