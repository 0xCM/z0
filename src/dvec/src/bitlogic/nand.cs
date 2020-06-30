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

    partial class dvec
    {         
        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<sbyte> vnand(Vector128<sbyte> x, Vector128<sbyte> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<byte> vnand(Vector128<byte> x, Vector128<byte> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<short> vnand(Vector128<short> x, Vector128<short> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<ushort> vnand(Vector128<ushort> x, Vector128<ushort> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<int> vnand(Vector128<int> x, Vector128<int> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<uint> vnand(Vector128<uint> x, Vector128<uint> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<long> vnand(Vector128<long> x, Vector128<long> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<ulong> vnand(Vector128<ulong> x, Vector128<ulong> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<float> vnand(Vector128<float> x, Vector128<float> y)
            => V0d.vnand(x,y);
        
        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector128<double> vnand(Vector128<double> x, Vector128<double> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<byte> vnand(Vector256<byte> x, Vector256<byte> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<short> vnand(Vector256<short> x, Vector256<short> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<sbyte> vnand(Vector256<sbyte> x, Vector256<sbyte> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<ushort> vnand(Vector256<ushort> x, Vector256<ushort> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<int> vnand(Vector256<int> x, Vector256<int> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<uint> vnand(Vector256<uint> x, Vector256<uint> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<long> vnand(Vector256<long> x, Vector256<long> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<ulong> vnand(Vector256<ulong> x, Vector256<ulong> y)
            => V0d.vnand(x,y);

        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<float> vnand(Vector256<float> x, Vector256<float> y)
            => V0d.vnand(x,y);
        
        /// <summary>
        /// Computes ~(x & y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Nand]
        public static Vector256<double> vnand(Vector256<double> x, Vector256<double> y)
            => V0d.vnand(x,y);
   }
}