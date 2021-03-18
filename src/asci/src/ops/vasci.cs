//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct Asci
    {
        /// <summary>
        /// Returns the uint16 asci scalar values corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        static ReadOnlySpan<ushort> scalars(sbyte offset, sbyte count)
            => recover<char,ushort>(chars(offset,count));

        /// Returns the asci characters corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(sbyte offset, sbyte count)
            => slice(recover<char>(AsciCharData.CharBytes), offset, count);

        /// <summary>
        /// Loads up to 16 asci scalar symbols [offset, offset + count]
        /// </summary>
        /// <param name="count">The number of symbols to load</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vasci(W256 w, sbyte offset, Hex4Seq count)
        {
            var src = scalars(offset, (sbyte)count);
            var target = default(Vector256<ushort>);
            ref var dst = ref gcpu.vref(ref target);
            for(byte i=0; i<(byte)count; i++)
                seek(dst,i) = skip(src,i);
            return target;
        }

        /// <summary>
        /// Loads up to 32 asci scalar symbols [offset, offset + count]
        /// </summary>
        /// <param name="count">The number of symbols to load</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vasci(W512 w, sbyte offset, Hex5Seq count)
        {
            var src = scalars(offset, (sbyte)count);
            var target = default(Vector512<ushort>);
            ref var dst = ref gcpu.vref(ref target);
            for(byte i=0; i<(byte)count; i++)
                seek(dst, i) = skip(src, i);
            return target;
        }
    }
}