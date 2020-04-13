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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> vbroadcast<T>(W128 w, T src)
            where T : unmanaged
                => vbroadcast_u(w, src);

        /// <summary>
        /// Projects a scalar value onto each component of a 256-bit vector
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector256<T> vbroadcast<T>(W256 w, T src)
            where T : unmanaged
                => vbroadcast_u(w, src);

        /// <summary>
        /// Projects a scalar value onto each component of a 512-bit vector
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector512<T> vbroadcast<T>(W512 w, T src)
            where T : unmanaged
                => (vbroadcast(w256,src), vbroadcast(w256,src));

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_u<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vbroadcast(w, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vbroadcast(w, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(vbroadcast(w, uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(vbroadcast(w, uint64(src)));
            else
                return vbroadcast_i(w,src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_i<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vbroadcast(w, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vbroadcast(w, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vbroadcast(w, int32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(vbroadcast(w, int64(src)));
            else
                return vbroadcast_f(w,src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vbroadcast_f<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  generic<T>(vbroadcast(w, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vbroadcast(w, float64(src)));
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_u<T>(W256 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vbroadcast(w, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vbroadcast(w, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(vbroadcast(w, uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(vbroadcast(w, uint64(src)));
            else
                return vbroadcast_i(w,src);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_i<T>(W256 w, T src)
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return generic<T>(vbroadcast(w, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vbroadcast(w, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vbroadcast(w, int32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(vbroadcast(w, int64(src)));
            else
                return vbroadcast_f(w,src);
       }

        [MethodImpl(Inline)]
        static Vector256<T> vbroadcast_f<T>(W256 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(vbroadcast(w, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vbroadcast(w, float64(src)));
            else 
                throw Unsupported.define<T>();
        }
    }
}