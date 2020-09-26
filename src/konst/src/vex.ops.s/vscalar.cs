//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vscalar(W128 w, sbyte a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vscalar(W128 w, byte a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vscalar(W128 w, short a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vscalar(W128 w, ushort a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vscalar(W128 w, int a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vscalar(W128 w, uint a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vscalar(W128 w, long a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vscalar(W128 w, ulong a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vscalar(W128 w, float a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vscalar(W128 w, double a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vscalar(W256 w, sbyte a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vscalar(W256 w, byte a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vscalar(W256 w, short a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vscalar(W256 w, ushort a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vscalar(W256 w, int a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vscalar(W256 w, uint a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vscalar(W256 w, long a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vscalar(W256 w, ulong a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vscalar(W256 w, float a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vscalar(W256 w, double a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="w">The width of the target vector</param>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> vscalar<T>(W128 w, T src)
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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector256<T> vscalar<T>(W256 w, T src)
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
        static Vector128<T> vscalar_u<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vscalar(w, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vscalar(w, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(vscalar(w, uint32(src)));
            else
                return generic<T>(vscalar(w, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_i<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vscalar(w, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vscalar(w, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vscalar(w, int32(src)));
            else
                return generic<T>(vscalar(w, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_f<T>(W128 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(vscalar(w, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vscalar(w, float64(src)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_u<T>(W256 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vscalar(w,uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vscalar(w,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(vscalar(w,uint32(src)));
            else
                return generic<T>(vscalar(w,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_i<T>(W256 w, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vscalar(w, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vscalar(w, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vscalar(w, int32(src)));
            else
                return generic<T>(vscalar(w, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_f<T>(W256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(vscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vscalar(n,float64(src)));
            else
                throw no<T>();
        }
    }
}