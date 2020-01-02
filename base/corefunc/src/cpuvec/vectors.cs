//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Extracts an index-identified component from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static T Cell<T>(this Vector128<T> src, int index)
            where T : unmanaged 
                => src.GetElement(index);
                
        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> Cell<T>(this Vector128<T> src, int index, T value)
            where T : unmanaged
                => src.WithElement(index,value);

        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Cell<T>(this Vector256<T> src, int index, T value)
            where T : unmanaged
                => src.WithElement(index,value);

        /// <summary>
        /// Extracts an index-identified component from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static T Cell<T>(this Vector256<T> src, int index)
            where T : unmanaged 
                => src.GetElement(index);


        [MethodImpl(Inline)]
        public static T FirstCell<T>(this Vector128<T> src)
            where T : unmanaged 
                => src.Cell(0);
        
        [MethodImpl(Inline)]
        public static T FirstCell<T>(this Vector256<T> src)
            where T : unmanaged 
                => src.Cell(0);

        [MethodImpl(Inline)]
        public static T LastCell<T>(this Vector128<T> src)
            where T : unmanaged 
        {
            if(Unsafe.SizeOf<T>() == 1)
                return src.Cell(15);
            else if(Unsafe.SizeOf<T>() == 2)
                return src.Cell(7);
            else if(Unsafe.SizeOf<T>() == 4)
                return src.Cell(3);
            else
                return src.Cell(1);
        }



        [MethodImpl(Inline)]
        public static T LastCell<T>(this Vector256<T> src)
            where T : unmanaged 
        {
            if(Unsafe.SizeOf<T>() == 1)
                return src.Cell(31);
            else if(Unsafe.SizeOf<T>() == 2)
                return src.Cell(15);
            else if(Unsafe.SizeOf<T>() == 4)
                return src.Cell(7);
            else
                return src.Cell(3);
        }

    }
}