//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    using static AsIn;
    
    partial class ginx
    {
        /// <summary>
        /// Computes the converse nonimplication, x & (~y)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vcnonimpl<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vcnonimpl(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcnonimpl(vcast16u(x),vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcnonimpl(vcast32u(x), vcast32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vcnonimpl(vcast64u(x), vcast64u(y)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the converse nonimplication, x & (~y)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vcnonimpl<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcnonimpl(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcnonimpl(vcast16u(x),vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcnonimpl(vcast32u(x), vcast32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vcnonimpl(vcast64u(x), vcast64u(y)));
            else 
                throw unsupported<T>();
        }

    }
}