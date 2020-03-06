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
    
    using static Root;
    using static gvec;

    partial class ginx
    {
        /// <summary>
        /// Computes the bitwise AND between the operors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vor_u(x,y);

        /// <summary>
        /// Computes the bitwise or
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vor_u(x,y);

        /// <summary>
        /// Computes the bitwise or
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector512<T> vor<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vor(x.Lo,y.Lo), (vor(x.Hi, y.Hi)));

        [MethodImpl(Inline)]
        static Vector128<T> vor_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vor(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vor(v64u(x), v64u(y)));
            else
                return vor_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vor_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vor(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.vor(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vor(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vor(v64u(x), v64u(y)));
            else
                return vor_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vor(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.vor(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }
    }
}