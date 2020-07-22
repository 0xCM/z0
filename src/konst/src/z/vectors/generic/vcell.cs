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
        public static T vcell<T>(Vector128<T> src, byte index)
            where T : unmanaged
                => src.GetElement(index);

        /// <summary>
        /// Returns a reference to an index-identified cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T vcell<T>(Vector256<T> src, byte index)
            where T : unmanaged
                => src.GetElement(index);
 
        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vcell<T>(Vector128<T> src, byte index, T value)
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
        public static Vector128<T> vcell<T>(T src, byte index, Vector128<T> dst)
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
        public static Vector256<T> vcell<T>(T src, byte index, Vector256<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);

       /// <summary>
        /// Extracts a T-indexed component from a vector obtained by converting the S-vector to a T-vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static T vcell<S,T>(Vector128<S> src, byte index)
            where S : unmanaged
            where T : unmanaged
                => src.As<S,T>().GetElement(index);
    }
}