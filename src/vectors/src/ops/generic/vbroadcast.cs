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

    using static Seed;
    using static Typed;
    using static As;

    partial class Vectors
    {
        /// <summary>
        /// Projects a scalar value onto each component of a 128-bit vector
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vbroadcast<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbroadcast_u(w, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbroadcast_i(w, src);
            else
                return vbroadcast_f(w, src);
        }

        /// <summary>
        /// Projects a scalar value onto each component of a 256-bit vector
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vbroadcast<T>(W256 w, T src)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbroadcast_u(w, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbroadcast_i(w, src);
            else
                return vbroadcast_f(w, src);
       }

        /// <summary>
        /// Projects a scalar value onto each component of a 512-bit vector
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector512<T> vbroadcast<T>(W512 w, T src)
            where T : unmanaged
                => (vbroadcast(w256,src), vbroadcast(w256,src));

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_i<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vbroadcast(w128, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vbroadcast(w128, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vbroadcast(w128, int32(src)));
            else 
                return generic<T>(vbroadcast(w128, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_u<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vbroadcast(w128, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vbroadcast(w128, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(vbroadcast(w128, uint32(src)));
            else 
                return generic<T>(vbroadcast(w128, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_f<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  generic<T>(vbroadcast(w128, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vbroadcast(w128, float64(src)));
            else 
                throw Unsupported.define<T>();
        }
 
        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_i<T>(W256 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vbroadcast(w256, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vbroadcast(w256, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vbroadcast(w256, int32(src)));
            else 
                return  generic<T>(broadcast(w256, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_u<T>(W256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vbroadcast(w256, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vbroadcast(w256, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(broadcast(w256, uint32(src)));
            else 
                return generic<T>(vbroadcast(w256, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_f<T>(W256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(vbroadcast(w256, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vbroadcast(w256, float64(src)));
            else 
                throw Unsupported.define<T>();
        }
    }
}