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

    public static class BlockedType
    {
        /// <summary>
        /// Enumerates the blocked data type definitions
        /// </summary>
        public static IEnumerable<Type> Types
            => items(typeof(Block16<>), typeof(Block32<>), typeof(Block64<>), typeof(Block128<>), typeof(Block256<>), typeof(Block512<>));

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one blocked parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool test(MethodInfo m)
            => m.ReturnType.IsBlocked() || m.ParameterTypes().Any(t => t.IsBlocked());        

        /// <summary>
        /// Determines whether a type is classified as a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool test(Type t)
        {
            if(t.IsGenericType)
            {
                var tdef = t.GetGenericTypeDefinition();
                if(
                    tdef == typeof(Block16<>) 
                 || tdef == typeof(Block32<>) 
                 || tdef == typeof(Block64<>)
                 || tdef == typeof(Block128<>)
                 || tdef == typeof(Block256<>)
                 || tdef == typeof(Block512<>)
                )
                    return true;                
            }
            return false;
        }

        /// <summary>
        /// Determines the width of a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockWidth width(Type t)
        {
            if(t.IsBlocked())
            {
                var def = t.GetGenericTypeDefinition();

                if(def == typeof(Block16<>))
                    return BlockWidth.W16;
                else if(def == typeof(Block32<>))
                    return BlockWidth.W32;
                else if (def == typeof(Block64<>))
                    return BlockWidth.W64;
                else if (def == typeof(Block128<>))
                    return BlockWidth.W128;
                else if (def == typeof(Block256<>))
                    return BlockWidth.W256;
                else if (def == typeof(Block512<>))
                    return BlockWidth.W512;
                else
                    return 0;
            }
            else
                return 0;
        }

        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockKind kind(Type t)
            => test(t) ? kind(width(t), segment(t)) : BlockKind.None;

        public static BlockKind kind<B>()
            where B :struct
                => kind(typeof(B));
        public static BlockKind kind(BlockWidth width, PrimalKind seg)            
            => (BlockKind)((uint)width | (((uint)seg >> 16) << 16));

        /// <summary>
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static PrimalKind segment(Type t)
            => test(t) ? t.GetGenericArguments().Single().Kind() : PrimalKind.None;

        [MethodImpl(Inline)]
        public static BlockKind kind<B>(B b = default)
            where B : struct
                => kind16_u<B>();

        [MethodImpl(Inline)]
        public static BlockKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(W) == typeof(N16))
                return kind<T>(n16);
            else if(typeof(W) == typeof(N32))
                return kind<T>(n32);
            else if(typeof(W) == typeof(N64))
                return kind<T>(n64);
            else if(typeof(W) == typeof(N128))
                return kind<T>(n128);
            else if(typeof(W) == typeof(N256))
                return kind<T>(n256);
            else if(typeof(W) == typeof(N512))
                return kind<T>(n512);
            else
                return BlockKind.None;
        }


        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N16 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N32 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N64 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N16 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.Block16x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.Block16x16u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N16 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.Block16x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.Block16x16i;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N32 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.Block32x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.Block32x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.Block32x32u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.Block32x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.Block32x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.Block32x32i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.Block32x32f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N64 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.Block64x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.Block64x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.Block64x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.Block64x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.Block64x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.Block64x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.Block64x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.Block64x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.Block64x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.Block64x64f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.Block128x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.Block128x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.Block128x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.Block128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.Block128x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.Block128x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.Block128x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.Block128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.Block128x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.Block128x64f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.Block256x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.Block256x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.Block256x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.Block256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.Block256x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.Block256x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.Block256x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.Block256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.Block256x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.Block256x64f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.Block512x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.Block512x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.Block512x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.Block512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.Block512x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.Block512x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.Block512x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.Block512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.Block512x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.Block512x64f;
            else
                return BlockKind.None;
        }



        [MethodImpl(Inline)]
        static BlockKind kind16_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block16<byte>))
                return BlockKind.Block16x8u;
            else if(typeof(T) == typeof(Block16<ushort>))
                return BlockKind.Block16x16u;
            else
                return kind16_i(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind16_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block16<sbyte>))
                return BlockKind.Block16x8i;
            else if(typeof(T) == typeof(Block16<short>))
                return BlockKind.Block16x16i;
            else
                return kind32_u<T>();
        }

        [MethodImpl(Inline)]
        static BlockKind kind32_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block32<byte>))
                return BlockKind.Block32x8u;
            else if(typeof(T) == typeof(Block32<ushort>))
                return BlockKind.Block32x16u;
            else if(typeof(T) == typeof(Block32<uint>))
                return BlockKind.Block32x32u;
            else
                return kind32_i(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind32_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block32<sbyte>))
                return BlockKind.Block32x8i;
            else if(typeof(T) == typeof(Block32<short>))
                return BlockKind.Block32x16i;
            else if(typeof(T) == typeof(Block32<int>))
                return BlockKind.Block32x32i;
            else
                return kind32_f(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind32_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block32<float>))
                return BlockKind.Block32x32f;
            else
                return kind64_u<T>();
        }

        [MethodImpl(Inline)]
        static BlockKind kind64_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block64<byte>))
                return BlockKind.Block64x8u;
            else if(typeof(T) == typeof(Block64<ushort>))
                return BlockKind.Block64x16u;
            else if(typeof(T) == typeof(Block64<uint>))
                return BlockKind.Block64x32u;
            else if(typeof(T) == typeof(Block64<ulong>))
                return BlockKind.Block64x64u;
            else
                return kind64_i(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind64_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block64<sbyte>))
                return BlockKind.Block64x8i;
            else if(typeof(T) == typeof(Block64<short>))
                return BlockKind.Block64x16i;
            else if(typeof(T) == typeof(Block64<int>))
                return BlockKind.Block64x32i;
            else if(typeof(T) == typeof(Block64<long>))
                return BlockKind.Block64x64i;
            else
                return kind64_f(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind64_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block64<float>))
                return BlockKind.Block64x32f;
            else if(typeof(T) == typeof(Block64<double>))
                return BlockKind.Block64x64f;
            else
                return kind128_u<T>();
        }


        [MethodImpl(Inline)]
        static BlockKind kind128_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block128<byte>))
                return BlockKind.Block128x8u;
            else if(typeof(T) == typeof(Block128<ushort>))
                return BlockKind.Block128x16u;
            else if(typeof(T) == typeof(Block128<uint>))
                return BlockKind.Block128x32u;
            else if(typeof(T) == typeof(Block128<ulong>))
                return BlockKind.Block128x64u;
            else
                return kind128_i(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind128_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block128<sbyte>))
                return BlockKind.Block128x8i;
            else if(typeof(T) == typeof(Block128<short>))
                return BlockKind.Block128x16i;
            else if(typeof(T) == typeof(Block128<int>))
                return BlockKind.Block128x32i;
            else if(typeof(T) == typeof(Block128<long>))
                return BlockKind.Block128x64i;
            else
                return kind128_f(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind128_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block128<float>))
                return BlockKind.Block128x32f;
            else if(typeof(T) == typeof(Block128<double>))
                return BlockKind.Block128x64f;
            else
                return kind256_u<T>();
        }

        [MethodImpl(Inline)]
        static BlockKind kind256_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block256<byte>))
                return BlockKind.Block256x8u;
            else if(typeof(T) == typeof(Block256<ushort>))
                return BlockKind.Block256x16u;
            else if(typeof(T) == typeof(Block256<uint>))
                return BlockKind.Block256x32u;
            else if(typeof(T) == typeof(Block256<ulong>))
                return BlockKind.Block256x64u;
            else
                return kind256_i(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind256_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block256<sbyte>))
                return BlockKind.Block256x8i;
            else if(typeof(T) == typeof(Block256<short>))
                return BlockKind.Block256x16i;
            else if(typeof(T) == typeof(Block256<int>))
                return BlockKind.Block256x32i;
            else if(typeof(T) == typeof(Block256<long>))
                return BlockKind.Block256x64i;
            else
                return kind256_f(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind256_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block256<float>))
                return BlockKind.Block256x32f;
            else if(typeof(T) == typeof(Block256<double>))
                return BlockKind.Block256x64f;
            else
                return kind512_u<T>();
        }

        [MethodImpl(Inline)]
        static BlockKind kind512_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block512<byte>))
                return BlockKind.Block512x8u;
            else if(typeof(T) == typeof(Block512<ushort>))
                return BlockKind.Block512x16u;
            else if(typeof(T) == typeof(Block512<uint>))
                return BlockKind.Block512x32u;
            else if(typeof(T) == typeof(Block512<ulong>))
                return BlockKind.Block512x64u;
            else
                return kind512_i(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind512_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block512<sbyte>))
                return BlockKind.Block512x8i;
            else if(typeof(T) == typeof(Block512<short>))
                return BlockKind.Block512x16i;
            else if(typeof(T) == typeof(Block512<int>))
                return BlockKind.Block512x32i;
            else if(typeof(T) == typeof(Block512<long>))
                return BlockKind.Block512x64i;
            else
                return kind512_f(t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind512_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Block512<float>))
                return BlockKind.Block512x32f;
            else if(typeof(T) == typeof(Block512<double>))
                return BlockKind.Block512x64f;
            else
                return BlockKind.None;            
        }


    }
}