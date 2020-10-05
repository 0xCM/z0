//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BlockedKinds
    {
        [MethodImpl(Inline)]
        public static SegBlockKind kind<W,T>(W w = default, T t = default)
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
                return SegBlockKind.None;
        }

        [MethodImpl(Inline)]
        public static SegBlockKind kind<T>(W16 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegBlockKind kind<T>(W32 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegBlockKind kind<T>(W64 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegBlockKind kind<T>(W128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegBlockKind kind<T>(W256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegBlockKind kind<T>(W512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);


        [MethodImpl(Inline)]
        static SegBlockKind kind_u<T>(W16 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegBlockKind.b16x8u;
            else if(typeof(T) == typeof(ushort))
                return SegBlockKind.b16x16u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_i<T>(W16 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegBlockKind.b16x8i;
            else if(typeof(T) == typeof(short))
                return SegBlockKind.b16x16i;
            else
                return SegBlockKind.None;
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_u<T>(W32 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegBlockKind.b32x8u;
            else if(typeof(T) == typeof(ushort))
                return SegBlockKind.b32x16u;
            else if(typeof(T) == typeof(uint))
                return SegBlockKind.b32x32u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_i<T>(W32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegBlockKind.b32x8i;
            else if(typeof(T) == typeof(short))
                return SegBlockKind.b32x16i;
            else if(typeof(T) == typeof(int))
                return SegBlockKind.b32x32i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_f<T>(W32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegBlockKind.b32x32f;
            else
                return SegBlockKind.None;
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_u<T>(W64 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegBlockKind.b64x8u;
            else if(typeof(T) == typeof(ushort))
                return SegBlockKind.b64x16u;
            else if(typeof(T) == typeof(uint))
                return SegBlockKind.b64x32u;
            else if(typeof(T) == typeof(ulong))
                return SegBlockKind.b64x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_i<T>(W64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegBlockKind.b64x8i;
            else if(typeof(T) == typeof(short))
                return SegBlockKind.b64x16i;
            else if(typeof(T) == typeof(int))
                return SegBlockKind.b64x32i;
            else if(typeof(T) == typeof(long))
                return SegBlockKind.b64x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_f<T>(W64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegBlockKind.b64x32f;
            else if(typeof(T) == typeof(double))
                return SegBlockKind.b64x64f;
            else
                return SegBlockKind.None;
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_u<T>(W128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegBlockKind.b128x8u;
            else if(typeof(T) == typeof(ushort))
                return SegBlockKind.b128x16u;
            else if(typeof(T) == typeof(uint))
                return SegBlockKind.b128x32u;
            else if(typeof(T) == typeof(ulong))
                return SegBlockKind.b128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_i<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegBlockKind.b128x8i;
            else if(typeof(T) == typeof(short))
                return SegBlockKind.b128x16i;
            else if(typeof(T) == typeof(int))
                return SegBlockKind.b128x32i;
            else if(typeof(T) == typeof(long))
                return SegBlockKind.b128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_f<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegBlockKind.b128x32f;
            else if(typeof(T) == typeof(double))
                return SegBlockKind.b128x64f;
            else
                return SegBlockKind.None;
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_u<T>(W256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegBlockKind.b256x8u;
            else if(typeof(T) == typeof(ushort))
                return SegBlockKind.b256x16u;
            else if(typeof(T) == typeof(uint))
                return SegBlockKind.b256x32u;
            else if(typeof(T) == typeof(ulong))
                return SegBlockKind.b256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_i<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegBlockKind.b256x8i;
            else if(typeof(T) == typeof(short))
                return SegBlockKind.b256x16i;
            else if(typeof(T) == typeof(int))
                return SegBlockKind.b256x32i;
            else if(typeof(T) == typeof(long))
                return SegBlockKind.b256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_f<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegBlockKind.b256x32f;
            else if(typeof(T) == typeof(double))
                return SegBlockKind.b256x64f;
            else
                return SegBlockKind.None;
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_u<T>(W512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegBlockKind.b512x8u;
            else if(typeof(T) == typeof(ushort))
                return SegBlockKind.b512x16u;
            else if(typeof(T) == typeof(uint))
                return SegBlockKind.b512x32u;
            else if(typeof(T) == typeof(ulong))
                return SegBlockKind.b512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_i<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegBlockKind.b512x8i;
            else if(typeof(T) == typeof(short))
                return SegBlockKind.b512x16i;
            else if(typeof(T) == typeof(int))
                return SegBlockKind.b512x32i;
            else if(typeof(T) == typeof(long))
                return SegBlockKind.b512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegBlockKind kind_f<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegBlockKind.b512x32f;
            else if(typeof(T) == typeof(double))
                return SegBlockKind.b512x64f;
            else
                return SegBlockKind.None;
        }
    }
}