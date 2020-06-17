//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class VectorType
    {
        /// <summary>
        /// Computes a 128-bit vector kind classifier for a parametrically-specified cell type
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="t">A represenative cell value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(W128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        /// <summary>
        /// Computes a 256-bit vector kind classifier for a parametrically-specified cell type
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="t">A represenative cell value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(W256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        /// <summary>
        /// Computes a 512-bit vector kind classifier for a parametrically-specified cell type
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="t">A represenative cell value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(W512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        static VectorKind kind_u<T>(W128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return VectorKind.v128x8u;
            else if(typeof(T) == typeof(ushort))
                return VectorKind.v128x16u;
            else if(typeof(T) == typeof(uint))
                return VectorKind.v128x32u;
            else if(typeof(T) == typeof(ulong))
                return VectorKind.v128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_i<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return VectorKind.v128x8i;
            else if(typeof(T) == typeof(short))
                return VectorKind.v128x16i;
            else if(typeof(T) == typeof(int))
                return VectorKind.v128x32i;
            else if(typeof(T) == typeof(long))
                return VectorKind.v128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_f<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return VectorKind.v128x32f;
            else if(typeof(T) == typeof(double))
                return VectorKind.v128x64f;
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        static VectorKind kind_u<T>(W256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return VectorKind.v256x8u;
            else if(typeof(T) == typeof(ushort))
                return VectorKind.v256x16u;
            else if(typeof(T) == typeof(uint))
                return VectorKind.v256x32u;
            else if(typeof(T) == typeof(ulong))
                return VectorKind.v256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_i<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return VectorKind.v256x8i;
            else if(typeof(T) == typeof(short))
                return VectorKind.v256x16i;
            else if(typeof(T) == typeof(int))
                return VectorKind.v256x32i;
            else if(typeof(T) == typeof(long))
                return VectorKind.v256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_f<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return VectorKind.v256x32f;
            else if(typeof(T) == typeof(double))
                return VectorKind.v256x64f;
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        static VectorKind kind_u<T>(W512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return VectorKind.v512x8u;
            else if(typeof(T) == typeof(ushort))
                return VectorKind.v512x16u;
            else if(typeof(T) == typeof(uint))
                return VectorKind.v512x32u;
            else if(typeof(T) == typeof(ulong))
                return VectorKind.v512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_i<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return VectorKind.v512x8i;
            else if(typeof(T) == typeof(short))
                return VectorKind.v512x16i;
            else if(typeof(T) == typeof(int))
                return VectorKind.v512x32i;
            else if(typeof(T) == typeof(long))
                return VectorKind.v512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_f<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return VectorKind.v512x32f;
            else if(typeof(T) == typeof(double))
                return VectorKind.v512x64f;
            else
                return VectorKind.None;
        }
    }
}