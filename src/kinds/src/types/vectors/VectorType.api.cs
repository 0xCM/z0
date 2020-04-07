//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Widths;

    public static class VectorType
    {
        /// <summary>
        /// Closed vector types of width 128
        /// </summary>
        public static IEnumerable<Type> Types128
            => types(w128);

        /// <summary>
        /// Closed vector types of width 256
        /// </summary>
        public static IEnumerable<Type> Types256
            => types(w256);

        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
            => t.IsVector();
        // {
        //     var eff = t.EffectiveType();
        //     var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
        //     if(def == null)
        //         return false;

        //     return def == typeof(Vector128<>) || def == typeof(Vector256<>) || VectorAttribute.Test(def);             
        // }


        [MethodImpl(Inline)]
        public static TypeWidth width(Type t)
            => Widths.vector(t);
        // {
        //     var eff = t.EffectiveType();
        //     var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
        //     if(def == null)
        //         return TypeWidth.None;
        //     else if(def == typeof(Vector128<>))            
        //         return TypeWidth.W128;
        //     else if(def == typeof(Vector256<>))
        //         return TypeWidth.W256;
        //     else
        //     {
        //         var tag = t.GetCustomAttribute<VectorAttribute>();
        //         if(tag != null)
        //             return tag.TotalWdth;
        //         else
        //             return TypeWidth.None;
        //     }            
        // }

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool test(Type t, int? w)        
        {
            if(!test(t))
                return false;            

            if(w == null)                
                return true;

            return ((int)width(t) == w);
        }

        [MethodImpl(Inline)]
        public static VectorKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W128))
                return VectorType.kind<T>(default(W128));
            else if(typeof(W) == typeof(W256))
                return VectorType.kind<T>(default(W256));
            else if(typeof(W) == typeof(W512))
                return VectorType.kind<T>(default(W512));
            else
                return VectorKind.None;
        }

        [MethodImpl(Inline)]
        public static VectorKind kind<T>(W128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static VectorKind kind<T>(W256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);


        [MethodImpl(Inline)]
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
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this VectorKind k)
            => width(k);
 
        /// <summary>
        /// Determines whether a classfied vector is defined over primal unsigned integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bool unsigned(VectorKind k)
            => (k & VectorKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal signed integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bool signed(VectorKind k)
            => (k & VectorKind.Signed) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bool floating(VectorKind k)
            => (k & VectorKind.Float) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bool integral(VectorKind k)
            => signed(k) || unsigned(k);

        [MethodImpl(Inline)]
        public static Type definition(W128 w)        
            => typeof(Vector128<>);
        
        [MethodImpl(Inline)]
        public static Type definition(W256 w)
            => typeof(Vector256<>);

        public static IEnumerable<Type> types(W128 w)
            => from nt in NumericKinds.NumericTypes select definition(w).MakeGenericType(nt);

        public static IEnumerable<Type> types(W256 w)
            => from nt in NumericKinds.NumericTypes select definition(w).MakeGenericType(nt);


        [MethodImpl(Inline)]
        public static VectorKind kind<T>(Vector128<T> v)
            where T : unmanaged
                => vkind128_u<Vector128<T>>();

        [MethodImpl(Inline)]
        public static VectorKind kind<T>(Vector256<T> v)
            where T : unmanaged
                => vkind256_u<Vector256<T>>();

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

            // else if(t == typeof(Vector512<byte>))
            //     return VectorKind.v512x8u;
            // else if(t == typeof(Vector512<ushort>))
            //     return VectorKind.v512x16u;
            // else if(t == typeof(Vector512<uint>))
            //     return VectorKind.v512x32u;
            // else if(t == typeof(Vector512<ulong>))
            //     return VectorKind.v512x64u;

            // else if(t == typeof(Vector512<sbyte>))
            //     return VectorKind.v512x8i;
            // else if(t == typeof(Vector512<short>))
            //     return VectorKind.v512x16i;
            // else if(t == typeof(Vector512<int>))
            //     return VectorKind.v512x32i;
            // else if(t == typeof(Vector512<long>))
            //     return VectorKind.v512x64i;

            // else if(t == typeof(Vector512<float>))
            //     return VectorKind.v512x32f;
            // else if(t == typeof(Vector512<double>))
            //     return VectorKind.v512x64f;
            else    
                return VectorKind.None;
        }
    }
}