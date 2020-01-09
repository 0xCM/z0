//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {

        /// <summary>
        /// Computes the material implication, x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector128<T> vimpl<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vimpl(v64u(x), v64u(y)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the material implication, x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector256<T> vimpl<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vimpl(v64u(x), v64u(y)));
            else 
                throw unsupported<T>();
        } 
    }
}