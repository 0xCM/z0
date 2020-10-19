//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Arrays
    {
        /// <summary>
        /// Concatenates a sequence of arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] concat<T>(IEnumerable<T[]> src)
            => concat(src.ToArray());

        /// <summary>
        /// Concatenates an array sequence
        /// </summary>
        /// <param name="src">The source arrays</param>
        [Op]
        public static void concat(byte[][] src, byte[] dst)
        {
            ref var target = ref first(span(dst));
            var k = 0u;

            var members = span(src);
            var terms = members.Length;
            for(uint i=0u; i<terms; i++)
            {
                var term = span(z.skip(members,i));
                Buffers.copy(first(term), (uint)term.Length, ref target, ref k);
            }
        }

        /// <summary>
        /// Concatenates an array sequence
        /// </summary>
        /// <param name="src">The source arrays</param>
        [MethodImpl(Inline), Op]
        public static byte[] concat(byte[][] src)
        {
            var members = span(src);
            var terms = members.Length;
            var items = 0;

            for(var i=0; i<terms; i++)
                items += members[i].Length;

            var dst = alloc<byte>(items);
            concat(src,dst);
            return dst;
        }

        /// <summary>
        /// Concatentates two arrays
        /// </summary>
        /// <param name="left">The first array</param>
        /// <param name="right">The second array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [Op, Closures(UnsignedInts)]
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
    }
}