//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        /// <summary>
        /// Returns the text right of, but not including, a specified index; or empty if invalid index is provided
        /// </summary>
        /// <param name="src"></param>
        /// <param name="index"></param>
        [MethodImpl(Inline), Op]
        public static string right(string src, int index)
        {
            var length = src.Length;
            var last = length - 1;
            var offset = index + 1;
            if(offset < last && offset >= 0)
                return slice(src,offset);
            else
                return EmptyString;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> right(ReadOnlySpan<char> src, int index)
        {
            var offset = index + 1;
            if(src.Length < offset)
                return default;
            else
                return core.slice(src, offset);
        }
    }
}