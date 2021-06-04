//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct TextTools
    {
        const NumericKind Closure = UInt64k;

        [Op]
        public static ITextBuffer buffer()
            => new TextBuffer(new StringBuilder());

        [Op]
        public static ITextBuffer buffer(uint capacity)
            => new TextBuffer(capacity);

        [MethodImpl(Inline), Op]
        public static ITextBuffer buffer(StringBuilder dst)
            => new TextBuffer(dst);

        [Op, Closures(Closure)]
        public static string delimit<T>(T[] src, char delimiter)
            => delimit(@readonly(src), delimiter);

        [Op, Closures(Closure)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter)
            => string.Join($"{delimiter} ", src);

        [Op, Closures(Closure)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter, int pad)
            => delimit(src, delimiter, pad, true);

        [Op, Closures(Closure)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter, int pad, bool space)
        {
            var dst = TextTools.buffer();
            var count = src.Length;
            var slot = RP.pad(pad);
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                dst.AppendFormat(slot, skip(src,i));
                if(i != last)
                {
                    dst.Append(delimiter);
                    if(space)
                        dst.Append(Chars.Space);
                }
            }
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter)
        {
            var dst = TextTools.buffer();
            var count = src.Length;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                dst.AppendItem(skip(src,i));

                if(i != last)
                {
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }

            }
            return dst.ToString();
        }

        [Op, Closures(Closure)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter, int pad)
            => delimit(src.ToSpan().ReadOnly(), delimiter, pad);


        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int offset)
            => sys.substring(src, offset);

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int offset, int length)
            => sys.substring(src, offset, length);

        /// <summary>
        /// Extracts a substring beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, uint offset)
            => sys.substring(src, (int)offset);

        /// <summary>
        /// Extracts a substring of specified length beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, uint offset, uint length)
            => sys.substring(src,(int)offset, (int)length);

    }
}