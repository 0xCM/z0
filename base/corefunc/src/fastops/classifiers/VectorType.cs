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
                var def = t.IsGenericRef() ? t.GetElementType().GetGenericTypeDefinition() : t.GetGenericTypeDefinition();

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
            var def = default(Type);

            if(t.IsGenericType)
                def = t.GetGenericTypeDefinition();
            else if(t.IsGenericRef())
                def = t.GetElementType().GetGenericTypeDefinition();
            else
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
        public static bool vector(Type t, int? width)        
        {
            if(test(t))
            {
                if(width == null)                
                    return true;
                else
                {
                    var def = t.IsGenericRef() ? t.GetElementType().GetGenericTypeDefinition() : t.GetGenericTypeDefinition();
                    if(def == typeof(Vector64<>) && width == 64)
                        return true;
                    else if(def == typeof(Vector128<>) && width == 128)
                        return true;
                    else if (def == typeof(Vector256<>) && width == 256)
                        return true;
                    else if (def == typeof(Vector512<>) && width == 512)
                        return true;
                    else if (def == typeof(Vector1024<>) && width == 1024)
                        return true;
                    else
                        return false;
                }
            }
            return false;
         
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
