//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static core;

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static unsafe string format(StringAddress src)
            => new string(gptr(firstchar(src)));

        [Op]
        public static string format(ReadOnlySpan<char> src, uint length)
            => new string(core.slice(src,0, length));

        [Op]
        public static string format(ReadOnlySpan<char> src)
            => new string(src);

        /// <summary>
        /// Creates a string from a span, via a specified encoding
        /// </summary>
        /// <param name="src">The data source</param>
        public static unsafe string format(ReadOnlySpan<byte> src, Encoding encoding)
        {
            if(src.IsEmpty)
                return EmptyString;

            fixed(byte* pSrc = src)
                return encoding.GetString(pSrc, src.Length);
        }
    }
}