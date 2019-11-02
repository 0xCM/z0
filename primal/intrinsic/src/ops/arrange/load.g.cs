//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static As;
    using static AsIn;

    using static zfunc;
    
    partial class ginx
    {        
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vload<T>(N128 n, in T src)
            where T : unmanaged                    
                => vloadu(constptr(in src), out Vector128<T> _);
        
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vload<T>(N256 n, in T src)
            where T : unmanaged
                => vloadu(constptr(in src), out Vector256<T> _);

        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vload<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
                => ref vloadu(constptr(in src), out dst);

        [MethodImpl(Inline)]
        public static unsafe ref Vector256<T> vload<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
                => ref vloadu(constptr(in src), out dst);

        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vload_u(n, in src, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vload_i(n,in src, offset);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vload_u(n, in src, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vload_i(n, in src, offset);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, Span<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, Span<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(Span128<T> src)
            where T : unmanaged
                =>  vload(n128,src.Unblocked);

        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(ReadOnlySpan128<T> src)
            where T : unmanaged
                =>  vload(n128,src.Unblocked);

        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(Span256<T> src)
            where T : unmanaged
                =>  vload(n256,src.Unblocked);

        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(ReadOnlySpan256<T> src)
            where T : unmanaged
                => vload(n256,src.Unblocked);

        [MethodImpl(Inline)]
        static Vector128<T> vload_u<T>(N128 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vload(n, in uint8(in src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vload(n, in uint16(in src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vload(n, in uint32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in uint64(in src), offset));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vload_i<T>(N128 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vload(n, in int8(in src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vload(n, in int16(in src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vload(n, in int32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in int64(in src), offset));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vload_u<T>(N256 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vload(n, in uint8(in src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vload(n, in uint16(in src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vload(n, in uint32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in uint64(in src), offset));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vload_i<T>(N256 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vload(n, in int8(in src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vload(n, in int16(in src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vload(n, in int32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in int64(in src), offset));
        }
    }
}
