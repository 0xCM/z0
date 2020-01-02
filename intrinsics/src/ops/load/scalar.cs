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
    
    using static zfunc;

    partial class dinx    
    {              
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vscalar(N128 n, sbyte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vscalar(N128 n, byte a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vscalar(N128 n, short a)
            => Vector128.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vscalar(N128 n, ushort a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vscalar(N128 n, int a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vscalar(N128 n, uint a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vscalar(N128 n, long a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vscalar(N128 n, ulong a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vscalar(N128 n, float a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vscalar(N128 n, double a)
            => Vector128.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vscalar(N256 n, sbyte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vscalar(N256 n, byte a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vscalar(N256 n, short a)
            => Vector256.CreateScalarUnsafe(a);
        
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vscalar(N256 n, ushort a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vscalar(N256 n, int a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vscalar(N256 n, uint a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vscalar(N256 n, long a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vscalar(N256 n, ulong a)
            => Vector256.CreateScalarUnsafe(a);
 
        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vscalar(N256 n, float a)
            => Vector256.CreateScalarUnsafe(a);

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vscalar(N256 n, double a)
            => Vector256.CreateScalarUnsafe(a);
    }
}