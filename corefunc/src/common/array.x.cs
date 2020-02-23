//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class xfunc
    {
        public static string Format<T>(this Vector512<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
            => bracket(concat(
                    src.Lo.Format(sep:sep, pad:pad, bracketed:false), 
                    $"{sep} ",
                    src.Hi.Format(sep:sep, pad:pad, bracketed:false)));

        public static string Format<T>(this Vector1024<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
            => bracket(concat(
                    src.A.Format(sep:AsciSym.Comma, bracketed:false), $"{sep} ",
                    src.B.Format(sep:AsciSym.Comma,bracketed:false), $"{sep} ",
                    src.C.Format(sep:AsciSym.Comma,bracketed:false), $"{sep} ",
                    src.D.Format(sep:AsciSym.Comma,bracketed:false))
                    );

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="offset">The position of the first element of the source array </param>
        /// <param name="count">The number of elements to take from the source array following the offset</param>
        public static T[] Slice<T>(this T[] src, int offset, int count)
        {
            var dst = new T[count];
            Array.Copy(src, offset, dst, 0, count);
            return dst;
        } 

        /// <summary>
        /// Creates a transformed array
        /// </summary>
        /// <typeparam name="S">The source item type</typeparam>
        /// <typeparam name="T">The target item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="transform">The transformation function</param>
        public static T[] ToArray<S, T>(this IEnumerable<S> src, Func<S, T> transform)
            => src.Select(transform).ToArray();

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="offset">The position of the first element of the source array </param>
        /// <param name="length">The position of the last element of the source array</param>
        public static T[] Subset<T>(this T[] src, int offset, int length)
            => src.Slice(offset,length);
 
        /// <summary>
        /// Copies a source list to a target array
        /// </summary>
        /// <param name="src">The list containing the elements to copy</param>
        /// <param name="dst">The array that will receive the copied elements</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void CopyTo<T>(this IReadOnlyList<T> src, T[] dst)
        {
            if(src.Count > dst.Length)
                throw new ArgumentException("The source list is bigger than the target array");

            for(var i=0; i< src.Count; i++)
                dst[i] = src[i];
        }

 
        /// <summary>
        /// Concatenates two arrays
        /// </summary>
        public static T[] ConcatArrays<T>(this T[] first, T[] second)
        {
            var dst = new T[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, dst, 0, first.Length);
            Buffer.BlockCopy(second, 0, dst, first.Length, second.Length);
            return dst;
        }


        /// <summary>
        /// Returns the index of the first value that matches a specified value, if any. Otherwise, returns -1
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="value">The value to match in the source</param>
        /// <typeparam name="T">The element type</typeparam>
        public static int FirstIndexOf<T>(this T[] src, T value)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i].Equals(value))
                    return i;
            return -1;
        }

        /// <summary>
        /// Creates a new array by sampling the source array at each specified index
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="indices">The indices that define the values to be extracted from the source</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Values<T>(this T[] src, int[] indices)
        {
            var dst = new T[indices.Length];
            for(var i=0; i< indices.Length; i++)
                dst[i] = src[indices[i]];
            return dst;
        }

    }
}