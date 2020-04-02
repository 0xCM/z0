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
    
    using static Core;
    using static VCore;

    partial class gvec
    {
        /// <summary>
        /// Permutes 4 128-bit source lanes from 2 256-bit vectors as described by the perm spec
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vperm2x128<T>(Vector256<T> x, Vector256<T> y, [Imm] byte spec)
            where T : unmanaged
                => vperm2x128_u(x,y,spec);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector512<T> vperm2x128<T>(in Vector512<T> src, [Imm] byte lo, [Imm] byte hi)
            where T : unmanaged
                => (vperm2x128(src.Lo, src.Hi, lo),vperm2x128(src.Lo, src.Hi, hi));

        [MethodImpl(Inline)]
        public static Vector512<T> vperm2x128<T>(in Vector512<T> src, Perm2x4 lo, Perm2x4 hi)
            where T : unmanaged
                => (vperm2x128(src.Lo, src.Hi, lo),vperm2x128(src.Lo, src.Hi, hi));

        /// <summary>
        /// Permutes 4 128-bit source lanes from 2 256-bit vectors as described by the perm spec
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vperm2x128<T>(Vector256<T> x, Vector256<T> y, Perm2x4 spec)
            where T : unmanaged
                => vperm2x128_u(x,y,(byte)spec);

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_u<T>(Vector256<T> lhs, Vector256<T> rhs, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vperm2x128(v8u(lhs), v8u(rhs), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vperm2x128(v16u(lhs), v16u(rhs), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vperm2x128(v32u(lhs), v32u(rhs), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vperm2x128(v64u(lhs), v64u(rhs), spec));
            else
                return vperm2x128_i(lhs,rhs,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_i<T>(Vector256<T> lhs, Vector256<T> rhs, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vperm2x128(v8i(lhs), v8i(rhs), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vperm2x128(v16i(lhs), v16i(rhs), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vperm2x128(v32i(lhs), v32i(rhs), spec));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vperm2x128(v64i(lhs), v64i(rhs), spec));
            else
                return vperm2x128_f(lhs,rhs,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_f<T>(Vector256<T> lhs, Vector256<T> rhs, byte spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinxfp.vperm2x128(v32f(lhs), v32f(rhs),spec));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinxfp.vperm2x128(v64f(lhs), v64f(rhs),spec));
            else
                throw Unsupported.define<T>();
        }
    }
}