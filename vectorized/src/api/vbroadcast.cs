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

    using static Root;
    using static Nats;
    using D = vdirect;

    partial class vgeneric
    {
        /// <summary>
        /// Projects a scalar value onto each component of a 128-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vbroadcast<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbroadcast_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbroadcast_i(n, src);
            else
                return vbroadcast_f(n, src);
        }

        /// <summary>
        /// Projects a scalar value onto each component of a 256-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vbroadcast<T>(N256 n, T src)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbroadcast_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbroadcast_i(n, src);
            else
                return vbroadcast_f(n, src);
       }

        /// <summary>
        /// Projects a scalar value onto each component of a 512-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector512<T> vbroadcast<T>(N512 n, T src)
            where T : unmanaged
                => (vbroadcast(n256,src), vbroadcast(n256,src));

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_i<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(D.vbroadcast(n128, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(D.vbroadcast(n128, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(D.vbroadcast(n128, int32(src)));
            else 
                return generic<T>(D.vbroadcast(n128, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_u<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(D.vbroadcast(n128, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(D.vbroadcast(n128, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(D.vbroadcast(n128, uint32(src)));
            else 
                return generic<T>(D.vbroadcast(n128, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_f<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  generic<T>(D.vbroadcast(n128, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(D.vbroadcast(n128, float64(src)));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_i<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(D.vbroadcast(n256, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(D.vbroadcast(n256, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(D.vbroadcast(n256, int32(src)));
            else 
                return  generic<T>(D.vbroadcast(n256, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_u<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(D.vbroadcast(n256, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(D.vbroadcast(n256, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(D.vbroadcast(n256, uint32(src)));
            else 
                return generic<T>(D.vbroadcast(n256, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_f<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(D.vbroadcast(n256, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(D.vbroadcast(n256, float64(src)));
            else 
                throw unsupported<T>();
        }
    }
}