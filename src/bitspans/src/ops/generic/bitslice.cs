//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitSpans
    {
        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T bitslice<T>(in BitSpan src, int offset)
            where T : unmanaged
        {
            var dst = span<bit>(bitsize<T>());
            var len = math.min(dst.Length, src.Length - offset);
            Copier.copy(src.Edit, offset, len, dst);
            return BitPack.pack<T>(dst);
        }

        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T bitslice<T>(in BitSpan src)
            where T : unmanaged
        {
            var dst = span<bit>(bitsize<T>());
            var len = math.min(dst.Length, src.Length);
            Copier.copy(src.Edit, 0, len, dst);
            return BitPack.pack<T>(dst);
        }

        /// <summary>
        /// Materializes an integral value from a bitspan segment
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="offset">The source index to begin extraction</param>
        /// <param name="count">The number of source bits that contribute to the extract</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T bitslice<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {
            var dst = span<bit>(bitsize<T>());
            var len = math.min(count, src.Length - offset);
            Copier.copy(src.Edit, offset, len, dst);
            return BitPack.pack<T>(dst);
        }
   }
}