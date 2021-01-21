//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class SegmentedKinds
    {
        [MethodImpl(Inline)]
        public static SegKind kind<W,T>(W w = default, T t = default)
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
                return SegKind.None;
        }

        [MethodImpl(Inline)]
        public static SegKind kind<T>(W16 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegKind kind<T>(W32 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegKind kind<T>(W64 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegKind kind<T>(W128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegKind kind<T>(W256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static SegKind kind<T>(W512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);


        [MethodImpl(Inline)]
        static SegKind kind_u<T>(W16 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegKind.b16x8u;
            else if(typeof(T) == typeof(ushort))
                return SegKind.b16x16u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_i<T>(W16 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegKind.b16x8i;
            else if(typeof(T) == typeof(short))
                return SegKind.b16x16i;
            else
                return SegKind.None;
        }

        [MethodImpl(Inline)]
        static SegKind kind_u<T>(W32 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegKind.b32x8u;
            else if(typeof(T) == typeof(ushort))
                return SegKind.b32x16u;
            else if(typeof(T) == typeof(uint))
                return SegKind.b32x32u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_i<T>(W32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegKind.b32x8i;
            else if(typeof(T) == typeof(short))
                return SegKind.b32x16i;
            else if(typeof(T) == typeof(int))
                return SegKind.b32x32i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_f<T>(W32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegKind.b32x32f;
            else
                return SegKind.None;
        }

        [MethodImpl(Inline)]
        static SegKind kind_u<T>(W64 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegKind.b64x8u;
            else if(typeof(T) == typeof(ushort))
                return SegKind.b64x16u;
            else if(typeof(T) == typeof(uint))
                return SegKind.b64x32u;
            else if(typeof(T) == typeof(ulong))
                return SegKind.b64x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_i<T>(W64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegKind.b64x8i;
            else if(typeof(T) == typeof(short))
                return SegKind.b64x16i;
            else if(typeof(T) == typeof(int))
                return SegKind.b64x32i;
            else if(typeof(T) == typeof(long))
                return SegKind.b64x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_f<T>(W64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegKind.b64x32f;
            else if(typeof(T) == typeof(double))
                return SegKind.b64x64f;
            else
                return SegKind.None;
        }

        [MethodImpl(Inline)]
        static SegKind kind_u<T>(W128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegKind.b128x8u;
            else if(typeof(T) == typeof(ushort))
                return SegKind.b128x16u;
            else if(typeof(T) == typeof(uint))
                return SegKind.b128x32u;
            else if(typeof(T) == typeof(ulong))
                return SegKind.b128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_i<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegKind.b128x8i;
            else if(typeof(T) == typeof(short))
                return SegKind.b128x16i;
            else if(typeof(T) == typeof(int))
                return SegKind.b128x32i;
            else if(typeof(T) == typeof(long))
                return SegKind.b128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_f<T>(W128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegKind.b128x32f;
            else if(typeof(T) == typeof(double))
                return SegKind.b128x64f;
            else
                return SegKind.None;
        }

        [MethodImpl(Inline)]
        static SegKind kind_u<T>(W256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegKind.b256x8u;
            else if(typeof(T) == typeof(ushort))
                return SegKind.b256x16u;
            else if(typeof(T) == typeof(uint))
                return SegKind.b256x32u;
            else if(typeof(T) == typeof(ulong))
                return SegKind.b256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_i<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegKind.b256x8i;
            else if(typeof(T) == typeof(short))
                return SegKind.b256x16i;
            else if(typeof(T) == typeof(int))
                return SegKind.b256x32i;
            else if(typeof(T) == typeof(long))
                return SegKind.b256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_f<T>(W256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegKind.b256x32f;
            else if(typeof(T) == typeof(double))
                return SegKind.b256x64f;
            else
                return SegKind.None;
        }

        [MethodImpl(Inline)]
        static SegKind kind_u<T>(W512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SegKind.b512x8u;
            else if(typeof(T) == typeof(ushort))
                return SegKind.b512x16u;
            else if(typeof(T) == typeof(uint))
                return SegKind.b512x32u;
            else if(typeof(T) == typeof(ulong))
                return SegKind.b512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_i<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return SegKind.b512x8i;
            else if(typeof(T) == typeof(short))
                return SegKind.b512x16i;
            else if(typeof(T) == typeof(int))
                return SegKind.b512x32i;
            else if(typeof(T) == typeof(long))
                return SegKind.b512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static SegKind kind_f<T>(W512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return SegKind.b512x32f;
            else if(typeof(T) == typeof(double))
                return SegKind.b512x64f;
            else
                return SegKind.None;
        }
    }
}