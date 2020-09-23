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

    partial class VectorKinds
    {
        /// <summary>
        /// Computes a vector kind classifier from a 128-bit vector instance
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(Vector128<T> src)
            where T : unmanaged
                => vkind128_u(src);

        /// <summary>
        /// Computes a vector kind classifier from a 256-bit vector instance
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(Vector256<T> src)
            where T : unmanaged
                => vkind256_u(src);

        /// <summary>
        /// Computes a vector kind classifier from a 512-bit vector instance
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(Vector512<T> src)
            where T : unmanaged
                => vkind512_u(src);

        /// <summary>
        /// Computes a 128-bit vector kind classifier for a parametrically-specified cell type
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="t">A representative cell value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(W128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        /// <summary>
        /// Computes a 256-bit vector kind classifier for a parametrically-specified cell type
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="t">A representative cell value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(W256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        /// <summary>
        /// Computes a 512-bit vector kind classifier for a parametrically-specified cell type
        /// </summary>
        /// <param name="w">The vector width</param>
        /// <param name="t">A representative cell value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Classify, Closures(AllNumeric)]
        public static VectorKind kind<T>(W512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        /// <summary>
        /// Computes the vector kind classifier determined by parametric width and cell types
        /// </summary>
        /// <param name="w">A width type representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static VectorKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W128))
                return VectorKinds.kind<T>(default(W128));
            else if(typeof(W) == typeof(W256))
                return VectorKinds.kind<T>(default(W256));
            else if(typeof(W) == typeof(W512))
                return VectorKinds.kind<T>(default(W512));
            else
                return VectorKind.None;
        }

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

        /// <summary>
        /// Computes the vector kind classifier determined by a system type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Classify]
        public static VectorKind kind(Type src)
        {
            var t = src.EffectiveType();
            if(t == typeof(Vector128<byte>))
                return VectorKind.v128x8u;
            else if(t == typeof(Vector128<ushort>))
                return VectorKind.v128x16u;
            else if(t == typeof(Vector128<uint>))
                return VectorKind.v128x32u;
            else if(t == typeof(Vector128<ulong>))
                return VectorKind.v128x64u;

            else if(t == typeof(Vector128<sbyte>))
                return VectorKind.v128x8i;
            else if(t == typeof(Vector128<short>))
                return VectorKind.v128x16i;
            else if(t == typeof(Vector128<int>))
                return VectorKind.v128x32i;
            else if(t == typeof(Vector128<long>))
                return VectorKind.v128x64i;

            else if(t == typeof(Vector128<float>))
                return VectorKind.v128x32f;
            else if(t == typeof(Vector128<double>))
                return VectorKind.v128x64f;

            else if(t == typeof(Vector256<byte>))
                return VectorKind.v256x8u;
            else if(t == typeof(Vector256<ushort>))
                return VectorKind.v256x16u;
            else if(t == typeof(Vector256<uint>))
                return VectorKind.v256x32u;
            else if(t == typeof(Vector256<ulong>))
                return VectorKind.v256x64u;

            else if(t == typeof(Vector256<sbyte>))
                return VectorKind.v256x8i;
            else if(t == typeof(Vector256<short>))
                return VectorKind.v256x16i;
            else if(t == typeof(Vector256<int>))
                return VectorKind.v256x32i;
            else if(t == typeof(Vector256<long>))
                return VectorKind.v256x64i;

            else if(t == typeof(Vector256<float>))
                return VectorKind.v256x32f;
            else if(t == typeof(Vector256<double>))
                return VectorKind.v256x64f;

            else if(t == typeof(Vector512<byte>))
                return VectorKind.v512x8u;
            else if(t == typeof(Vector512<ushort>))
                return VectorKind.v512x16u;
            else if(t == typeof(Vector512<uint>))
                return VectorKind.v512x32u;
            else if(t == typeof(Vector512<ulong>))
                return VectorKind.v512x64u;

            else if(t == typeof(Vector512<sbyte>))
                return VectorKind.v512x8i;
            else if(t == typeof(Vector512<short>))
                return VectorKind.v512x16i;
            else if(t == typeof(Vector512<int>))
                return VectorKind.v512x32i;
            else if(t == typeof(Vector512<long>))
                return VectorKind.v512x64i;

            else if(t == typeof(Vector512<float>))
                return VectorKind.v512x32f;
            else if(t == typeof(Vector512<double>))
                return VectorKind.v512x64f;
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        static VectorKind vkind128_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<byte>))
                return VectorKind.v128x8u;
            else if(typeof(T) == typeof(Vector128<ushort>))
                return VectorKind.v128x16u;
            else if(typeof(T) == typeof(Vector128<uint>))
                return VectorKind.v128x32u;
            else if(typeof(T) == typeof(Vector128<ulong>))
                return VectorKind.v128x64u;
            else
                return vkind128_i(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind128_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<sbyte>))
                return VectorKind.v128x8i;
            else if(typeof(T) == typeof(Vector128<short>))
                return VectorKind.v128x16i;
            else if(typeof(T) == typeof(Vector128<int>))
                return VectorKind.v128x32i;
            else if(typeof(T) == typeof(Vector128<long>))
                return VectorKind.v128x64i;
            else
                return vkind128_f(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind128_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<float>))
                return VectorKind.v128x32f;
            else if(typeof(T) == typeof(Vector128<double>))
                return VectorKind.v128x64f;
            else
                return default;
        }

        [MethodImpl(Inline)]
        static VectorKind vkind256_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<byte>))
                return VectorKind.v256x8u;
            else if(typeof(T) == typeof(Vector256<ushort>))
                return VectorKind.v256x16u;
            else if(typeof(T) == typeof(Vector256<uint>))
                return VectorKind.v256x32u;
            else if(typeof(T) == typeof(Vector256<ulong>))
                return VectorKind.v256x64u;
            else
                return vkind256_i(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind256_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<sbyte>))
                return VectorKind.v256x8i;
            else if(typeof(T) == typeof(Vector256<short>))
                return VectorKind.v256x16i;
            else if(typeof(T) == typeof(Vector256<int>))
                return VectorKind.v256x32i;
            else if(typeof(T) == typeof(Vector256<long>))
                return VectorKind.v256x64i;
            else
                return vkind256_f(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind256_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<float>))
                return VectorKind.v256x32f;
            else if(typeof(T) == typeof(Vector256<double>))
                return VectorKind.v256x64f;
            else
                return default;
        }

        [MethodImpl(Inline)]
        static VectorKind vkind512_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector512<byte>))
                return VectorKind.v512x8u;
            else if(typeof(T) == typeof(Vector512<ushort>))
                return VectorKind.v512x16u;
            else if(typeof(T) == typeof(Vector512<uint>))
                return VectorKind.v512x32u;
            else if(typeof(T) == typeof(Vector512<ulong>))
                return VectorKind.v512x64u;
            else
                return vkind512_i(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind512_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector512<sbyte>))
                return VectorKind.v512x8i;
            else if(typeof(T) == typeof(Vector512<short>))
                return VectorKind.v512x16i;
            else if(typeof(T) == typeof(Vector512<int>))
                return VectorKind.v512x32i;
            else if(typeof(T) == typeof(Vector512<long>))
                return VectorKind.v512x64i;
            else
                return vkind512_f(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind512_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector512<float>))
                return VectorKind.v512x32f;
            else if(typeof(T) == typeof(Vector512<double>))
                return VectorKind.v512x64f;
            else
                return default;
        }
    }
}