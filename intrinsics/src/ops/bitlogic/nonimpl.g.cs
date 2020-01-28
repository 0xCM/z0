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
    using static AsIn;
    
    partial class ginx
    {
        /// <summary>
        /// Computes the material nomimplication, ~x & y for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static Vector128<T> vnonimpl<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vnonimpl_u(x,y);

        /// <summary>
        /// Computes the material nomimplication, ~x & y for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static Vector256<T> vnonimpl<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vnonimpl_u(x,y);

        [MethodImpl(Inline)]
        static Vector128<T> vnonimpl_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnonimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnonimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnonimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vnonimpl(v64u(x), v64u(y)));
            else 
                return vnonimpl_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnonimpl_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnonimpl(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnonimpl(v16i(x),v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnonimpl(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vnonimpl(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vnonimpl_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnonimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnonimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnonimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vnonimpl(v64u(x), v64u(y)));
            else 
                return vnonimpl_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnonimpl_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnonimpl(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnonimpl(v16i(x),v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnonimpl(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vnonimpl(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }

    }
}