//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class BlockedTypeKinds
    {
        [MethodImpl(Inline)]
        public static BlockedKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W16))
                return kind<T>(default(W16));
            else if(typeof(W) == typeof(W32))
                return kind<T>(default(W32));
            else if(typeof(W) == typeof(W64))
                return kind<T>(default(W64));
            else if(typeof(W) == typeof(W128))
                return kind<T>(default(W128));
            else if(typeof(W) == typeof(W256))
                return kind<T>(default(W256));
            else if(typeof(W) == typeof(W512))
                return kind<T>(default(W512));
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(W16 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(W32 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(W64 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(W128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(W256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(W512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedTypeKind<T> bk<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W,T> bk<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W16,T> bk<T>(W16 w, T t = default)
            where T : unmanaged, ITypeWidth
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W32,T> bk<T>(W32 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W64,T> bk<T>(W64 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W128,T> bk<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W256,T> bk<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedTypeKind<W512,T> bk<T>(W512 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(W16 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b16x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b16x16u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(W16 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b16x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b16x16i;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(W32 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b32x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b32x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b32x32u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(W32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b32x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b32x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b32x32i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(W32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b32x32f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(W64 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b64x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b64x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b64x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b64x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(W64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b64x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b64x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b64x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b64x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(W64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b64x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b64x64f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(W128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b128x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b128x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b128x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b128x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b128x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b128x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b128x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b128x64f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(W256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b256x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b256x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b256x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b256x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b256x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b256x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b256x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b256x64f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(W512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b512x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b512x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b512x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b512x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b512x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b512x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b512x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b512x64f;
            else
                return BlockedKind.None;
        }        
    }
}