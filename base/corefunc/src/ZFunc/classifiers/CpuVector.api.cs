//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;

    using static zfunc;

    partial class Classified
    {

        [MethodImpl(Inline)]
        public static CpuVectorKind vectorkind<T>(T t = default)
            where T : struct
            =>  typeof(T).IsGenericType ?
                (
                     typeof(T).GetGenericTypeDefinition() == typeof(Vector128<>)  ? vkind128_u(t) 
                   : typeof(T).GetGenericTypeDefinition() == typeof(Vector256<>)  ? vkind256_u(t)
                   : CpuVectorKind.None
                )
              :  CpuVectorKind.None;

        /// <summary>
        /// Determines whether a parametric type is of a specified kind
        /// </summary>
        /// <param name="kind">The kind</param>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit iskind<T>(CpuVectorKind kind, T t = default)
            where T : struct
                => vectorkind<T>() == kind;

        [MethodImpl(Inline)]
        public static bit isvector<T>(T t = default)
            where T : unmanaged
                => vectorkind<T>() != CpuVectorKind.None;

        [MethodImpl(Inline)]
        public static CpuVectorKind vectorkind(Type t)
        {
            if(t == typeof(Vector128<byte>))
                return CpuVectorKind.v16x8u;
            else if(t == typeof(Vector128<ushort>))
                return CpuVectorKind.v8x16u;
            else if(t == typeof(Vector128<uint>))
                return CpuVectorKind.v4x32u;
            else if(t == typeof(Vector128<ulong>))
                return CpuVectorKind.v2x64u;

            else if(t == typeof(Vector128<sbyte>))
                return CpuVectorKind.v16x8i;
            else if(t == typeof(Vector128<short>))
                return CpuVectorKind.v8x16i;
            else if(t == typeof(Vector128<int>))
                return CpuVectorKind.v4x32i;
            else if(t == typeof(Vector128<long>))            
                return CpuVectorKind.v2x64i;
                
            else if(t == typeof(Vector128<float>))
                return CpuVectorKind.v4x32f;
            else if(t == typeof(Vector128<double>))
                return CpuVectorKind.v2x64f;

            else if(t == typeof(Vector256<byte>))
                return CpuVectorKind.v32x8u;
            else if(t == typeof(Vector256<ushort>))
                return CpuVectorKind.v16x16u;
            else if(t == typeof(Vector256<uint>))
                return CpuVectorKind.v8x32u;
            else if(t == typeof(Vector256<ulong>))
                return CpuVectorKind.v4x64u;

            else if(t == typeof(Vector256<sbyte>))
                return CpuVectorKind.v32x8i;
            else if(t == typeof(Vector256<short>))
                return CpuVectorKind.v16x16i;
            else if(t == typeof(Vector256<int>))
                return CpuVectorKind.v8x32i;
            else if(t == typeof(Vector256<long>))
                return CpuVectorKind.v4x64i;

            else if(t == typeof(Vector256<float>))
                return CpuVectorKind.v8x32f;
            else if(t == typeof(Vector256<double>))
                return CpuVectorKind.v4x64f;
            else    
                return CpuVectorKind.None;
        }

        [MethodImpl(Inline)]
        public static bit isvector(Type t)
            => vectorkind(t) != CpuVectorKind.None;

        /// <summary>
        /// Determines the number of bits covered by a k-kinded vector
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(CpuVectorKind k)
            => width((uint)k);

        /// <summary>
        /// Determines the component width of a k-kinded vector
        /// </summary>
        /// <param name="k">The vector kind</param>
        [MethodImpl(Inline)]
        public static int segwidth(CpuVectorKind k)
            => (byte)((uint)k >> 16);

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(CpuVectorKind kind)
            => width(kind)/8;

        /// <summary>
        /// Produces a character {i | u | f} indicating whether a classified vector is defined over signed, unsigned or floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]   
        public static char sign(CpuVectorKind k)
            => sign((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over primal integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit integral(CpuVectorKind k)
            => integral((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over primal unsigned integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit unsignedint(CpuVectorKind k)
            => unsignedint((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over primal signed integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit signedint(CpuVectorKind k)
            => signedint((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit floating(CpuVectorKind k)
            => floating((uint)k);

        [MethodImpl(Inline)]
        static CpuVectorKind vkind128_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<byte>))
                return CpuVectorKind.v16x8u;
            else if(typeof(T) == typeof(Vector128<ushort>))
                return CpuVectorKind.v8x16u;
            else if(typeof(T) == typeof(Vector128<uint>))
                return CpuVectorKind.v4x32u;
            else if(typeof(T) == typeof(Vector128<ulong>))
                return CpuVectorKind.v2x64u;
            else
                return vkind128_i(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind128_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<sbyte>))
                return CpuVectorKind.v16x8i;
            else if(typeof(T) == typeof(Vector128<short>))
                return CpuVectorKind.v8x16i;
            else if(typeof(T) == typeof(Vector128<int>))
                return CpuVectorKind.v4x32i;
            else if(typeof(T) == typeof(Vector128<long>))
                return CpuVectorKind.v2x64i;
            else
                return vkind128_f(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind128_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<float>))
                return CpuVectorKind.v4x32f;
            else if(typeof(T) == typeof(Vector128<double>))
                return CpuVectorKind.v2x64f;
            else
                return CpuVectorKind.None;            
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind256_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<byte>))
                return CpuVectorKind.v32x8u;
            else if(typeof(T) == typeof(Vector256<ushort>))
                return CpuVectorKind.v16x16u;
            else if(typeof(T) == typeof(Vector256<uint>))
                return CpuVectorKind.v8x32u;
            else if(typeof(T) == typeof(Vector256<ulong>))
                return CpuVectorKind.v4x64u;
            else
                return vkind256_i(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind256_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<sbyte>))
                return CpuVectorKind.v32x8i;
            else if(typeof(T) == typeof(Vector256<short>))
                return CpuVectorKind.v16x16i;
            else if(typeof(T) == typeof(Vector256<int>))
                return CpuVectorKind.v8x32i;
            else if(typeof(T) == typeof(Vector256<long>))
                return CpuVectorKind.v4x64i;
            else
                return vkind256_f(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind256_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<float>))
                return CpuVectorKind.v8x32f;
            else if(typeof(T) == typeof(Vector256<double>))
                return CpuVectorKind.v4x64f;
            else
                return CpuVectorKind.None;            
        }
    }

}