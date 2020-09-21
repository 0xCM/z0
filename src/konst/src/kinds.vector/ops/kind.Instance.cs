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