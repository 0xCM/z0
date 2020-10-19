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

    partial struct asci
    {
        /// <summary>
        /// Converts 16 source characters to 16 asci codes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source characters to convert</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static void encode(in char src, uint offset, N16 count, ref AsciCharCode dst)
            => vsave(vcompact(vload(w256, memory.read(src, offset)), w8), ref @byte(dst));

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
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = z.cast<T>((byte)skip(src,i));
            return count;
        }

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
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
        /// Encodes a single character
        /// </summary>
        /// <param name="src">The character to encode</param>
        [MethodImpl(Inline), Op]
        public static AsciCharCode encode(char src)
            => (AsciCharCode)src;

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, ref byte dst)
            => encode(z.first(src), src.Length, ref dst);

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
                z.seek(dst, ++j) = delimiter;
            }
            return j + 1;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci2 encode(in char src, Hex1Seq count, out asci2 dst)
        {
            dst = asci2.Null;
            ref var codes = ref Unsafe.As<asci2,AsciCharCode>(ref dst);
            asci.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci4 encode(in char src, Hex2Seq count, out asci4 dst)
        {
            dst = asci4.Null;
            ref var codes = ref Unsafe.As<asci4,AsciCharCode>(ref dst);
            asci.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci8 encode(in char src, Hex3Seq count, out asci8 dst)
        {
            dst = asci8.Null;
            ref var codes = ref Unsafe.As<asci8,AsciCharCode>(ref dst);
            asci.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci16 encode(in char src, Hex4Seq count, out asci16 dst)
        {
            dst = asci16.Null;
            ref var codes = ref Unsafe.As<asci16,AsciCharCode>(ref dst);
            asci.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci32 encode(in char src, Hex5Seq count, out asci32 dst)
        {
            dst = asci32.Null;
            ref var codes = ref Unsafe.As<asci32,AsciCharCode>(ref dst);
            asci.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Populates an asci target with a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of characters to encode</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci64 encode(in char src, Hex6Seq count, out asci64 dst)
        {
            dst = asci64.Null;
            ref var codes = ref Unsafe.As<asci64,AsciCharCode>(ref dst);
            asci.codes(src, (byte)count, ref codes);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied target span with asci codes corresponding to characters in a source span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<AsciCharCode> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (AsciCharCode)skip(src,i);
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
        public static uint encode(ReadOnlySpan<char> src, uint offset, uint count, Span<AsciCharCode> dst)
        {
            ref readonly var input = ref skip(src, offset);
            ref var target = ref z.first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = (AsciCharCode)skip(input,i);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly AsciSequence encode(string src, in AsciSequence dst)
        {
            var buffer = dst.Storage.Data;
            encode(src, buffer);
            return ref dst;
        }

        /// <summary>
        /// Populates a 2-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci2 encode(ReadOnlySpan<char> src, out asci2 dst)
        {
            dst = default;

            codes(src, span<asci2,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci4 encode(ReadOnlySpan<char> src, out asci4 dst)
        {
            dst = default;
            codes(src, span<asci4,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci8 encode(ReadOnlySpan<char> src, out asci8 dst)
        {
            dst = default;
            codes(src, span<asci8,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci16 encode(ReadOnlySpan<char> src, out asci16 dst)
        {
            dst = asci16.Spaced;
            codes(src, span<asci16,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci32 encode(ReadOnlySpan<char> src, out asci32 dst)
        {
            dst = asci32.Spaced;
            codes(src, span<asci32,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 64-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly asci64 encode(ReadOnlySpan<char> src, out asci64 dst)
        {
            dst = asci64.Spaced;
            codes(src, span<asci64,AsciCharCode>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 2-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci2 encode(N2 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci2 dst);

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci4 encode(N4 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci4 dst);

        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci8 encode(N8 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci8 dst);

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci16 encode(N16 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci16 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci32 encode(N32 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci32 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci64 encode(N64 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci64 dst);
    }
}