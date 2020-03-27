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
    using static vgeneric;

    partial class gvec
    {
        /// <summary>
        /// Computes the bitwise complement ~x for a vector x
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Not, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vnot<T>(Vector128<T> x)
            where T : unmanaged
                => vnot_u(x);

        /// <summary>
        /// Computes the bitwise complement ~x for a vector x
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Not, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vnot<T>(Vector256<T> x)
            where T : unmanaged
                => vnot_u(x);

        /// <summary>
        /// Computes the bitwise complement ~x for a vector x
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Not, NumericClosures(NumericKind.All)]
        public static Vector512<T> vnot<T>(in Vector512<T> x)
            where T : unmanaged
                => (vnot(x.Lo), vnot(x.Hi));

        [MethodImpl(Inline)]
        static Vector128<T> vnot_u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vnot(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vnot(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vnot(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vnot(v64u(x)));
            else
                return vnot_i(x);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnot_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vnot(v8i(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vnot(v16i(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vnot(v32i(x)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vnot(v64i(x)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_u<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vnot(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vnot(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vnot(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vnot(v64u(x)));
            else
                return vnot_i(x);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_i<T>(Vector256<T> x)
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vnot(v8i(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vnot(v16i(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vnot(v32i(x)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vnot(v64i(x)));
            else
                throw Unsupported.define<T>();
       }
    }
}