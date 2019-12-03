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
    
    using static zfunc;

    partial class dinx    
    {              
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vmovscalar(N128 n, sbyte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vmovscalar(N128 n, byte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vmovscalar(N128 n, short a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> movscalar(N128 n, ushort a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vmovscalar(N128 n, int a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vmovscalar(N128 n, uint a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vmovscalar(N128 n, long a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vmovscalar(N128 n, ulong a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vmovscalar(N128 n, float a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vmovscalar(N128 n, double a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vmovscalar(N256 n, sbyte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vmovscalar(N256 n, byte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vmovscalar(N256 n, short a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vmovscalar(N256 n, ushort a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vmovscalar(N256 n, int a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vmovscalar(N256 n, uint a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vmovscalar(N256 n, long a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vmovscalar(N256 n, ulong a)
            => Vector256.CreateScalarUnsafe(a);
 
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vmovscalar(N256 n, float a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vmovscalar(N256 n, double a)
            => Vector256.CreateScalarUnsafe(a);
    }
}