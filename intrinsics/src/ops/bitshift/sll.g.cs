//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    partial class ginx
    {
        /// <summary>
        /// Shifts each source vector component leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.Integers)]
        public static Vector128<T> vsll<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsll_u(x,count);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsll_i(x,count);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Shifts each source vector component leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.Integers)]
        public static Vector256<T> vsll<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsll_u(x,count);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsll_i(x,count);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_i<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsll(v8i(x), offset));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsll(v16i(x), offset));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsll(v32i(x), offset));
            else 
                return vgeneric<T>(dinx.vsll(v64i(x), offset));            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_u<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsll(v8u(x), offset));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsll(v16u(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsll(v32u(x), offset));
            else 
                return vgeneric<T>(dinx.vsll(v64u(x), offset));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_i<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsll(v8i(x), shift));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsll(v16i(x), shift));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsll(v32i(x), shift));
            else 
                return vgeneric<T>(dinx.vsll(v64i(x), shift));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_u<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsll(v8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsll(v16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsll(v32u(x), shift));
            else 
                return vgeneric<T>(dinx.vsll(v64u(x), shift));
        }
    }
}