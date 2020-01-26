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
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class VectorType
    {
        /// <summary>
        /// Determines the component width of a k-kinded vector
        /// </summary>
        /// <param name="k">The vector kind</param>
        [MethodImpl(Inline)]
        public static int segwidth(VectorKind k)
            => (byte)((uint)k >> 16);

        /// <summary>
        /// Determines the number of bits covered by a k-kinded vector
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(VectorKind k)
            => (ushort)k;

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(VectorKind kind)
            => width(kind)/8;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal unsigned integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit unsigned(VectorKind k)
            => (k & VectorKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal signed integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit signed(VectorKind k)
            => (k & VectorKind.Signed) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit floating(VectorKind k)
            => (k & VectorKind.Fractional) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit integral(VectorKind k)
            => signed(k) || unsigned(k);


        [MethodImpl(Inline)]
        public static VectorKind kind<V>(V v = default)
            where V : struct
                => vkind128_u<V>();

        [MethodImpl(Inline)]
        public static VectorKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(W) == typeof(N128))
                return kind<T>(n128);
            else if(typeof(W) == typeof(N256))
                return kind<T>(n256);
            else if(typeof(W) == typeof(N512))
                return kind<T>(n512);
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        public static VectorKind kind<T>(N128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static VectorKind kind<T>(N256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static VectorKind kind<T>(N512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static VectorKind kind(Type src)
        {
            var t = src.EffectiveType();
            if(t == typeof(Vector128<byte>))
                return VectorKind.Vector128x8u;
            else if(t == typeof(Vector128<ushort>))
                return VectorKind.Vector128x16u;
            else if(t == typeof(Vector128<uint>))
                return VectorKind.Vector128x32u;
            else if(t == typeof(Vector128<ulong>))
                return VectorKind.Vector128x64u;

            else if(t == typeof(Vector128<sbyte>))
                return VectorKind.Vector128x8i;
            else if(t == typeof(Vector128<short>))
                return VectorKind.Vector128x16i;
            else if(t == typeof(Vector128<int>))
                return VectorKind.Vector128x32i;
            else if(t == typeof(Vector128<long>))            
                return VectorKind.Vector128x64i;
                
            else if(t == typeof(Vector128<float>))
                return VectorKind.Vector128x32f;
            else if(t == typeof(Vector128<double>))
                return VectorKind.Vector128x64f;

            else if(t == typeof(Vector256<byte>))
                return VectorKind.Vector256x8u;
            else if(t == typeof(Vector256<ushort>))
                return VectorKind.Vector256x16u;
            else if(t == typeof(Vector256<uint>))
                return VectorKind.Vector256x32u;
            else if(t == typeof(Vector256<ulong>))
                return VectorKind.Vector256x64u;

            else if(t == typeof(Vector256<sbyte>))
                return VectorKind.Vector256x8i;
            else if(t == typeof(Vector256<short>))
                return VectorKind.Vector256x16i;
            else if(t == typeof(Vector256<int>))
                return VectorKind.Vector256x32i;
            else if(t == typeof(Vector256<long>))
                return VectorKind.Vector256x64i;

            else if(t == typeof(Vector256<float>))
                return VectorKind.Vector256x32f;
            else if(t == typeof(Vector256<double>))
                return VectorKind.Vector256x64f;

            else if(t == typeof(Vector512<byte>))
                return VectorKind.Vector512x8u;
            else if(t == typeof(Vector512<ushort>))
                return VectorKind.Vector512x16u;
            else if(t == typeof(Vector512<uint>))
                return VectorKind.Vector512x32u;
            else if(t == typeof(Vector512<ulong>))
                return VectorKind.Vector512x64u;

            else if(t == typeof(Vector512<sbyte>))
                return VectorKind.Vector512x8i;
            else if(t == typeof(Vector512<short>))
                return VectorKind.Vector512x16i;
            else if(t == typeof(Vector512<int>))
                return VectorKind.Vector512x32i;
            else if(t == typeof(Vector512<long>))
                return VectorKind.Vector512x64i;

            else if(t == typeof(Vector512<float>))
                return VectorKind.Vector512x32f;
            else if(t == typeof(Vector512<double>))
                return VectorKind.Vector512x64f;
            else    
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        public static VectorWidth width(Type t)
        {
            if(test(t))
            {
                var def = t.GenericDefinition();
                if(def == typeof(Vector128<>))
                    return VectorWidth.W128;
                else if (def == typeof(Vector256<>))
                    return VectorWidth.W256;
                else if (def == typeof(Vector512<>))
                    return VectorWidth.W512;
                else if (def == typeof(Vector1024<>))
                    return VectorWidth.W1024;
                else
                    return VectorWidth.None;
            }
            else 
                return VectorWidth.None;
        }

        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return false;

            return(        
                def == typeof(Vector128<>) 
             || def == typeof(Vector256<>) 
             || def == typeof(Vector1024<>) 
             || def == typeof(Vector512<>)
             || def == typeof(Vector1024<>)
             );
        }

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool vector(Type t, int? w)        
        {
            if(!test(t))
                return false;

            if(w == null)                
                return true;

            return ((int)width(t) == w);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_u<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return VectorKind.Vector128x8u;
            else if(typeof(T) == typeof(ushort))
                return VectorKind.Vector128x16u;
            else if(typeof(T) == typeof(uint))
                return VectorKind.Vector128x32u;
            else if(typeof(T) == typeof(ulong))
                return VectorKind.Vector128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_i<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return VectorKind.Vector128x8i;
            else if(typeof(T) == typeof(short))
                return VectorKind.Vector128x16i;
            else if(typeof(T) == typeof(int))
                return VectorKind.Vector128x32i;
            else if(typeof(T) == typeof(long))
                return VectorKind.Vector128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_f<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return VectorKind.Vector128x32f;
            else if(typeof(T) == typeof(double))
                return VectorKind.Vector128x64f;
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        static VectorKind kind_u<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return VectorKind.Vector256x8u;
            else if(typeof(T) == typeof(ushort))
                return VectorKind.Vector256x16u;
            else if(typeof(T) == typeof(uint))
                return VectorKind.Vector256x32u;
            else if(typeof(T) == typeof(ulong))
                return VectorKind.Vector256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_i<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return VectorKind.Vector256x8i;
            else if(typeof(T) == typeof(short))
                return VectorKind.Vector256x16i;
            else if(typeof(T) == typeof(int))
                return VectorKind.Vector256x32i;
            else if(typeof(T) == typeof(long))
                return VectorKind.Vector256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_f<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return VectorKind.Vector256x32f;
            else if(typeof(T) == typeof(double))
                return VectorKind.Vector256x64f;
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        static VectorKind kind_u<T>(N512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return VectorKind.Vector512x8u;
            else if(typeof(T) == typeof(ushort))
                return VectorKind.Vector512x16u;
            else if(typeof(T) == typeof(uint))
                return VectorKind.Vector512x32u;
            else if(typeof(T) == typeof(ulong))
                return VectorKind.Vector512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_i<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return VectorKind.Vector512x8i;
            else if(typeof(T) == typeof(short))
                return VectorKind.Vector512x16i;
            else if(typeof(T) == typeof(int))
                return VectorKind.Vector512x32i;
            else if(typeof(T) == typeof(long))
                return VectorKind.Vector512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static VectorKind kind_f<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return VectorKind.Vector512x32f;
            else if(typeof(T) == typeof(double))
                return VectorKind.Vector512x64f;
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        static VectorKind vkind128_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<byte>))
                return VectorKind.Vector128x8u;
            else if(typeof(T) == typeof(Vector128<ushort>))
                return VectorKind.Vector128x16u;
            else if(typeof(T) == typeof(Vector128<uint>))
                return VectorKind.Vector128x32u;
            else if(typeof(T) == typeof(Vector128<ulong>))
                return VectorKind.Vector128x64u;
            else
                return vkind128_i(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind128_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<sbyte>))
                return VectorKind.Vector128x8i;
            else if(typeof(T) == typeof(Vector128<short>))
                return VectorKind.Vector128x16i;
            else if(typeof(T) == typeof(Vector128<int>))
                return VectorKind.Vector128x32i;
            else if(typeof(T) == typeof(Vector128<long>))
                return VectorKind.Vector128x64i;
            else
                return vkind128_f(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind128_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<float>))
                return VectorKind.Vector128x32f;
            else if(typeof(T) == typeof(Vector128<double>))
                return VectorKind.Vector128x64f;
            else
                return vkind256_u<T>();
        }


        [MethodImpl(Inline)]
        static VectorKind vkind256_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<byte>))
                return VectorKind.Vector256x8u;
            else if(typeof(T) == typeof(Vector256<ushort>))
                return VectorKind.Vector256x16u;
            else if(typeof(T) == typeof(Vector256<uint>))
                return VectorKind.Vector256x32u;
            else if(typeof(T) == typeof(Vector256<ulong>))
                return VectorKind.Vector256x64u;
            else
                return vkind256_i(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind256_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<sbyte>))
                return VectorKind.Vector256x8i;
            else if(typeof(T) == typeof(Vector256<short>))
                return VectorKind.Vector256x16i;
            else if(typeof(T) == typeof(Vector256<int>))
                return VectorKind.Vector256x32i;
            else if(typeof(T) == typeof(Vector256<long>))
                return VectorKind.Vector256x64i;
            else
                return vkind256_f(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind256_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<float>))
                return VectorKind.Vector256x32f;
            else if(typeof(T) == typeof(Vector256<double>))
                return VectorKind.Vector256x64f;
            else
                return vkind512_u<T>();
        }

        [MethodImpl(Inline)]
        static VectorKind vkind512_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector512<byte>))
                return VectorKind.Vector512x8u;
            else if(typeof(T) == typeof(Vector512<ushort>))
                return VectorKind.Vector512x16u;
            else if(typeof(T) == typeof(Vector512<uint>))
                return VectorKind.Vector512x32u;
            else if(typeof(T) == typeof(Vector512<ulong>))
                return VectorKind.Vector512x64u;
            else
                return vkind512_i(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind512_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector512<sbyte>))
                return VectorKind.Vector512x8i;
            else if(typeof(T) == typeof(Vector512<short>))
                return VectorKind.Vector512x16i;
            else if(typeof(T) == typeof(Vector512<int>))
                return VectorKind.Vector512x32i;
            else if(typeof(T) == typeof(Vector512<long>))
                return VectorKind.Vector512x64i;
            else
                return vkind512_f(t);
        }

        [MethodImpl(Inline)]
        static VectorKind vkind512_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector512<float>))
                return VectorKind.Vector512x32f;
            else if(typeof(T) == typeof(Vector512<double>))
                return VectorKind.Vector512x64f;
            else
                return VectorKind.None;            
        }

    }

}
