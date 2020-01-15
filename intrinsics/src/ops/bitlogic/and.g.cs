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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vand_u(x,y);

        /// <summary>
        /// Computes the bitwise and
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vand_u(x,y);

        /// <summary>
        /// Computes the bitwise and
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op,PrimalClosures(PrimalKind.Integers)]
        public static Vector512<T> vand<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vand(x.Lo,y.Lo), (vand(x.Hi, y.Hi)));

        [MethodImpl(Inline)]
        static Vector128<T> vand_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vand(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vand(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vand(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vand(v64u(x), v64u(y)));
            else
                return vand_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vand_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vand(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vand(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vand(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vand(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vand_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vand(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vand(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vand(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vand(v64u(x), v64u(y)));
            else
                return vand_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vand_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vand(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vand(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vand(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vand(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }
    }
}
