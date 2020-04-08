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
    using static Memories;

    partial class gvec
    {
        /// <summary>
        /// Computes the component-wise sum of two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vadd_u(x,y);
        
        /// <summary>
        /// Computes the component-wise sum of two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vadd_u(x,y);
        
        /// <summary>
        /// Computes the component-wise sum of two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector512<T> vadd<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vadd(x.Lo,y.Lo),vadd(x.Hi, y.Hi));
        
        /// <summary>
        /// Adds a constant value to each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="a">The value to add to each component</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Closures(NumericKind.All)]
        public static Vector128<T> vadd<T>(Vector128<T> x, T a)
            where T : unmanaged
                => vadd(x, Vectors.vbroadcast(n128,a));

        /// <summary>
        /// Adds a constant value to each vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="a">The value to add to each component</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Closures(NumericKind.All)]
        public static Vector256<T> vadd<T>(Vector256<T> x, T a)
            where T : unmanaged
                => vadd(x, Vectors.vbroadcast(n256,a));

        /// <summary>
        /// Adds a constant value to each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="a">The value to add to each component</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Closures(NumericKind.All)]
        public static Vector512<T> vadd<T>(Vector512<T> x, T a)
            where T : unmanaged
                => vadd(x, Vectors.vbroadcast(n512,a));

        [MethodImpl(Inline)]
        static Vector128<T> vadd_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vadd(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vadd(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vadd(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vadd(v64u(x), v64u(y)));
            else
                return vadd_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vadd_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vadd(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vadd(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vadd(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dvec.vadd(v64i(x), v64i(y)));
            else
                return ginxfp.vadd(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vadd_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vadd(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vadd(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vadd(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vadd(v64u(x), v64u(y)));
            else
                return vadd_i(x,y);
        }    

        [MethodImpl(Inline)]
        static Vector256<T> vadd_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vadd(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vadd(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vadd(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dvec.vadd(v64i(x), v64i(y)));
            else
                return ginxfp.vadd(x,y);
        }    
    }
}