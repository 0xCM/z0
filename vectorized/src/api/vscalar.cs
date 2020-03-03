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
    using static As;
    using D = VScalar;

    partial class Vectors
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
                return vgeneric<T>(D.vscalar(n, int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(D.vscalar(n, int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(D.vscalar(n,int32(src)));
            else
                return vgeneric<T>(D.vscalar(n,int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_u<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(D.vscalar(n, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(D.vscalar(n,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(D.vscalar(n,uint32(src)));
            else 
                return vgeneric<T>(D.vscalar(n,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vscalar_f<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(D.vscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(D.vscalar(n,float64(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_i<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(D.vscalar(n,int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(D.vscalar(n,int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(D.vscalar(n,int32(src)));
            else
                return vgeneric<T>(D.vscalar(n,int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_u<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(D.vscalar(n,uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(D.vscalar(n,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(D.vscalar(n,uint32(src)));
            else 
                return vgeneric<T>(D.vscalar(n,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vscalar_f<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(D.vscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(D.vscalar(n,float64(src)));
            else 
                throw unsupported<T>();
        }
    }

    static class VScalar
    {
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vscalar(N128 n, sbyte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vscalar(N128 n, byte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vscalar(N128 n, short a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vscalar(N128 n, ushort a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vscalar(N128 n, int a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vscalar(N128 n, uint a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vscalar(N128 n, long a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vscalar(N128 n, ulong a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vscalar(N128 n, float a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vscalar(N128 n, double a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vscalar(N256 n, sbyte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vscalar(N256 n, byte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vscalar(N256 n, short a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vscalar(N256 n, ushort a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vscalar(N256 n, int a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vscalar(N256 n, uint a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vscalar(N256 n, long a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vscalar(N256 n, ulong a)
            => Vector256.CreateScalarUnsafe(a);
 
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vscalar(N256 n, float a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vscalar(N256 n, double a)
            => Vector256.CreateScalarUnsafe(a);
    }
}