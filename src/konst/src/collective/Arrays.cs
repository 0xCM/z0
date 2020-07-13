//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;    
    using System.Linq;

    using static Konst;
    
    [ApiHost]
    public static class Arrays
    {            
        /// <summary>
        /// Returns an empty array
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T[] empty<T>()
             => sys.empty<T>();

        /// <summary>
        /// Returns a reference to the location of the first element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static unsafe ref T head<T>(T[] src)
            => ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Adds an offset to the head of an array, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly T skip<T>(T[] src, int count)
            => ref z.skip(in head<T>(src), (uint)count);

        /// <summary>
        /// Adds an offset to the head of an array, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref T seek<T>(T[] src, int count)
            => ref z.seek(head<T>(src), count);

        /// <summary>
        /// Tests whether an array is empty
        /// </summary>
        /// <param name="src">The array to test</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bool empty<T>(T[] src)
            =>  src == null || src.Length == 0;

        /// <summary>
        /// Allocates a new array
        /// </summary>
        /// <param name="length">The array length</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Integers)]
        public static T[] alloc<T>(int length)
            => new T[length];

        /// <summary>
        /// Allocates a new array and populates it with a specified value
        /// </summary>
        /// <param name="length">The array length</param>
        /// <param name="src">The value with which to populate the array</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Integers)]
        public static T[] alloc<T>(int length, T src)
        {
            var dst = alloc<T>(length);
            return fill(dst,src);
        }            

        [Op, Closures(Integers)]
        public static T[] from<T>(IEnumerable<T> src)
            => src.ToArray();

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T[] from<T>(params T[] src)
            => src;

        /// <summary>
        /// Fills an array, in-place, with a specified value
        /// </summary>
        /// <param name="dst">The target array</param>
        /// <param name="dst">The source value</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T[] fill<T>(T[] dst, T src)
        {
            Array.Fill(dst, src);
            return dst;
        }

        /// <summary>
        /// Fills an array with the element type's default value
        /// </summary>
        /// <param name="dst">The source array</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T[] clear<T>(T[] dst)
            where T : struct
        {
            if(dst != null)
                Array.Fill(dst, default(T));
            return dst;
        }

        /// <summary>
        /// Constructs an array filled with a replicated value
        /// </summary>
        /// <param name="value">The value to replicate</param>
        /// <param name="count">The number of replicants</param>
        /// <typeparam name="T">The replicant type</typeparam>
        [Op, Closures(Integers)]
        public static T[] replicate<T>(T value, int count)
        {
            var dst = alloc<T>(count);
            for(var idx = 0U; idx < count; idx ++)
                dst[idx] = value;
            return dst;            
        }

        /// <summary>
        /// Reverses an array in-place
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T[] reverse<T>(T[] src)
        {
            Array.Reverse(src);
            return src;        
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void copy<T>(T[] src, T[] dst)
            => Array.Copy(src,dst, src.Length);

        /// <summary>
        /// Concatenates a sequence of arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        public static T[] concat<T>(IEnumerable<T[]> src)
            => concat(src.ToArray());   

        /// <summary>
        /// Concatenates a sequence of byte arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        [Op]
        public static byte[] concat(IEnumerable<byte[]> src)
        {
            byte[] ret = new byte[src.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in src)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        [Op, Closures(Integers)]
        public static IEnumerable<T> singletons<T>(params IEnumerable<T>[] src)
            where T : unmanaged
                => src.SelectMany(x => x);

        /// <summary>
        /// Creates a new array by sampling the source array at each specified index
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="indices">The indices that define the values to be extracted from the source</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Integers)]
        public static T[] indexed<T>(T[] src, int[] indices)
        {
            var dst = new T[indices.Length];
            for(var i=0; i< indices.Length; i++)
                dst[i] = src[indices[i]];
            return dst;
        }     

        /// <summary>
        /// Concatentates two arrays
        /// </summary>
        /// <param name="left">The first array</param>
        /// <param name="right">The second array</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static T[] concat<T>(T[] left, T[] right)
        {
            var length = left.Length + right.Length;
            var dst = alloc<T>(length);
            left.CopyTo(dst,0);
            right.CopyTo(dst, left.Length);
            return dst;
        }   

        /// <summary>
        /// Concatentates two byte arrays
        /// </summary>
        /// <param name="left">The first array</param>
        /// <param name="right">The second array</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        [MethodImpl(Inline)]
        public static byte[] concat(byte[] left, byte[] right)
        {
            var ret = alloc<byte>(left.Length + right.Length);
            Buffer.BlockCopy(left, 0, ret, 0, left.Length);
            Buffer.BlockCopy(right, 0, ret, left.Length, right.Length);
            return ret;
        }

        /// <summary>
        /// Concatenates a sequence of parameter arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        public static T[] concat<T>(params T[][] src)
        {
            var totalLen = src.Sum(x => x.Length);
            var dst = new T[totalLen];
            var idx = 0;
            for(var i=0; i< src.Length; i++)
            {
                var arr = src[i];
                var len = arr.Length;
                for(var j = 0; j<len; j++)
                    dst[idx++] = arr[j];            
            }        
            return dst;
        }

        /// <summary>
        /// Concatentates a parameter array of byte arrays
        /// </summary>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        [Op]
        public static byte[] concat(params byte[][] src)
         {
            byte[] ret = new byte[src.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in src)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }
    }
}