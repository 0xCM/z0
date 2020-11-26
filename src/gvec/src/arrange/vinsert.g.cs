//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class gvec
    {
        /// <summary>
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively designating low or hi</param>
        [MethodImpl(Inline), Closures(AllNumeric)]
        public static Vector256<T> vinsert<T>(Vector128<T> src, Vector256<T> dst, [Imm] byte index)
            where T : unmanaged
                => vinsert_u(src,dst,(BitState)index);

        /// <summary>
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively designating low or hi</param>
        [MethodImpl(Inline), Closures(AllNumeric)]
        public static Vector256<T> vinsert<T>(Vector128<T> src, Vector256<T> dst, [Imm] BitState index)
            where T : unmanaged
                => vinsert_u(src,dst,index);

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_u<T>(Vector128<T> src, Vector256<T> dst, BitState index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vinsert(v8u(src), v8u(dst), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vinsert(v16u(src), v16u(dst), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vinsert(v64i(src), v64i(dst), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vinsert(v64u(src), v64u(dst), index));
            else
                return vinsert_i(src,dst,index);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_i<T>(Vector128<T> src, Vector256<T> dst, BitState index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(z.vinsert(v8i(src), v8i(dst), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(z.vinsert(v16i(src), v16i(dst), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(z.vinsert(v32i(src), v32i(dst), index));
            else if(typeof(T) == typeof(long))
                return generic<T>(z.vinsert(v64i(src), v64i(dst), index));
            else
                return vinsert_f(src,dst,index);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_f<T>(Vector128<T> src, Vector256<T> dst, BitState index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.vinsert(v32f(src), v32f(dst), index));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.vinsert(v64f(src), v64f(dst), index));
            else
                throw no<T>();
        }
    }
}