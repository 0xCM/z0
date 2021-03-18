//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    partial class XText
    {
        /// <summary>
        /// Partitions a string into parts of a specified maximum width
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="maxlen">The maximum length of a partition</param>
        [TextUtility]
        public static IEnumerable<string> Partition(this string src, int maxlen)
        {
            var count = src.Length;
            Span<char> buffer = stackalloc char[maxlen];

            for(int i=0, j=0; i<count; i++, j++)
            {
                if(j < maxlen)
                    buffer[j] = src[i];
                else
                {
                    yield return new string(buffer);

                    buffer = new char[maxlen];
                    j = 0;
                    buffer[j] = src[i];
                }
            }

            var trim = buffer.Trim();
            if(trim.Length != 0)
                yield return new string(trim);
        }
    }
}