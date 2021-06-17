//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct TextTools
    {
        /// <summary>
        /// Returns the content preceeding the first null-termininator, if extant; oterwise, returns the input clamped to a specified maxumim count, if any
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="max">The maximum length of the returned content</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> @string(ReadOnlySpan<char> src, uint? max = null)
        {
            var counter = 0u;
            var count = max == null ? src.Length : min(src.Length, max.Value);
            for(var i=0; i<count; i++)
            {
                if(skip(src,i) == 0)
                    break;
                counter++;
            }

            return core.slice(src,0,counter);
        }
    }
}