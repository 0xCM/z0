//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Core;
    using static As;
    using D = vdirect;

    partial class vgeneric
    {
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="w">The width of the target vector</param>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vscalar<T>(N128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vscalar_u(w, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vscalar_i(w, src);
            else 
                return vscalar_f(w, src);
        }

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vscalar<T>(N256 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vscalar_u(w, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vscalar_i(w, src);
            else 
                return vscalar_f(w, src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_i<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(D.vscalar(n, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(D.vscalar(n, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(D.vscalar(n,int32(src)));
            else
                return generic<T>(D.vscalar(n,int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_u<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(D.vscalar(n, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(D.vscalar(n,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(D.vscalar(n,uint32(src)));
            else 
                return generic<T>(D.vscalar(n,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_f<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(D.vscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(D.vscalar(n,float64(src)));
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_i<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(D.vscalar(n,int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(D.vscalar(n,int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(D.vscalar(n,int32(src)));
            else
                return generic<T>(D.vscalar(n,int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_u<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(D.vscalar(n,uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(D.vscalar(n,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(D.vscalar(n,uint32(src)));
            else 
                return generic<T>(D.vscalar(n,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_f<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(D.vscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(D.vscalar(n,float64(src)));
            else 
                throw Unsupported.define<T>();
        }
    }
}