//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static aux;

    partial class ginx
    {
        /// <summary>
        /// Projects a scalar value onto each component of a 128-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vbroadcast<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbc_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbc_i(n, src);
            else
                return vbc_f(n, src);
        }

        /// <summary>
        /// Projects a scalar value onto each component of a 256-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vbroadcast<T>(N256 n, T src)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbc_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbc_i(n, src);
            else
                return vbc_f(n, src);
       }

    }

}