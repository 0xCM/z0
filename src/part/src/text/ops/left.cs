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
        /// Returns the text left of, but not including, a specified index; or empty if invalid index is provided
        /// </summary>
        /// <param name="src"></param>
        /// <param name="index"></param>
        [Op]
        public static string left(string src, int index)
        {
            var length = src?.Length ?? 0;
            if(length == 0 || index < 0 || index > length - 1)
                return EmptyString;
            else
                return slice(src, 0, index);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> left(ReadOnlySpan<char> src, int index)
        {
            var length = src.Length;
            if(length == 0 || index < 0 || index > length - 1)
                return default;
            else
                return core.slice(src,0,index);
        }
    }
}