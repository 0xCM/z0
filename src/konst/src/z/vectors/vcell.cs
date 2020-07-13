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
        /// Returns a reference to an index-identified cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vcell<T>(in Vector128<T> src, byte index)
            where T : unmanaged
                => ref add(vfirst(src), index);

        /// <summary>
        /// Returns a reference to an index-identified cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vcell<T>(in Vector256<T> src, byte index)
            where T : unmanaged
                => ref add(vfirst(src), index);                

        /// <summary>
        /// Returns a reference to an index-identified cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vcell<T>(in Vector512<T> src, byte index)
            where T : unmanaged
                => ref add(vfirst(src), index);                

        /// <summary>
        /// Extracts a T-indexed component from a vector obtained by converting the S-vector to a T-vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T vcell<S,T>(Vector128<S> src, int index)
            where S : unmanaged
            where T : unmanaged
                => src.As<S,T>().GetElement(index);

        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vcell<T>(Vector128<T> src, int index, T value)
            where T : unmanaged
                => src.WithElement(index,value);

        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vcell<T>(T src, int index, Vector128<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);
                
        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vcell<T>(T src, int index, Vector256<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte vcell8i<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v8i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte vcell8<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v8u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static short vcell16i<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v16i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort vcell16<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v16u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int vcell32i<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v32i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint vcell32<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v32u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static long vcell64i<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v64i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong vcell64<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v64u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static float vcell32f<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v32f(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static double vcell64f<T>(Vector128<T> x, int index)
            where T : unmanaged
                => v64f(x).GetElement(index);
            
        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte vcell8i<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v8i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte vcell8<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v8u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static short vcell16i<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v16i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort vcell16<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v16u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int vcell32i<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v32i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint vcell32<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v32u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong vcell64<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v64u(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static long vcell64i<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v64i(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static float vcell32f<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v32f(x).GetElement(index);

        /// <summary>
        /// Extract an index-identified component of a reinterpreted vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static double vcell64f<T>(Vector256<T> x, int index)
            where T : unmanaged
                => v64f(x).GetElement(index);
    }
}