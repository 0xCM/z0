//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct AsciSymbols
    {
        [MethodImpl(Inline), Op]
        public static ref readonly AsciSequence encode(string src, in AsciSequence dst)
        {
            AsciSymbols.encode(src, dst.Storage);
            return ref dst;
        }

        /// <summary>
        /// Encodes a single character
        /// </summary>
        /// <param name="src">The character to encode</param>
        [MethodImpl(Inline), Op]
        public static AsciCode encode(char src)
            => (AsciCode)src;

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, ref byte dst)
            => encode(first(src), src.Length, ref dst);

        /// <summary>
        /// Encodes each source string and packs the result into the target
        /// </summary>
        /// <param name="src">The encoding source</param>
        /// <param name="dst">The encoding target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<string> src, Span<byte> dst)
        {
            var j = 0;
            for(var i=0u; i<src.Length; i++)
                j += encode(skip(src, i), dst.Slice(j));
            return j + 1;
        }

        /// <summary>
        /// Encodes each source string and packs the result into the target, interspersed by a supplied delimiter
        /// </summary>
        /// <param name="src">The encoding source</param>
        /// <param name="dst">The encoding target</param>
        [MethodImpl(Inline), Op]
        public static uint encode(ReadOnlySpan<string> src, Span<byte> dst, byte delimiter)
        {
            var j=0u;
            for(var i=0u; i<src.Length; i++)
            {
                j += (uint)(encode(skip(src, i), slice(dst,j)));
                seek(dst, ++j) = delimiter;
            }
            return j + 1;
        }

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static int encode(in char src, int count, ref byte dst)
        {
            for(var i=0u; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
            return count;
        }

        /// <summary>
        /// Fills a caller-supplied target span with asci codes corresponding to characters in a source span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<AsciCode> dst)
        {
            var count = min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (AsciCode)skip(src,i);
            return count;
        }

        /// <summary>
        /// Encodes a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="dst">The data target</param>
        [MethodImpl(Inline), Op]
        public static uint encode(ReadOnlySpan<char> src, uint offset, uint count, Span<AsciCode> dst)
        {
            ref readonly var input = ref skip(src, offset);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = (AsciCode)skip(input,i);
            return count;
        }

        /// <summary>
        /// Encodes a sequence of source characters and stores a result in a caller-supplied
        /// T-parametric target with cells assumed to be at least 16 bits wide
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static int encode<T>(ReadOnlySpan<char> src, Span<T> dst)
        {
            var count = min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = @as<T>((byte)skip(src,i));
            return count;
        }
    }
}