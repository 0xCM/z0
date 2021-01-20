//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using C = AsciCharCode;

    partial struct AsciTest
    {
        /// <summary>
        /// Determines whether the test code is a term of a specified sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="match">The test value</param>
        [MethodImpl(Inline), Op]
        public static bit contains(ReadOnlySpan<C> src, C match)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(match == skip(src,i))
                    return 1;
            return 0;
        }

        /// <summary>
        /// Determines whether the test code is within a specified range
        /// </summary>
        /// <param name="min">The inclusive minimum code value</param>
        /// <param name="max">The inclusive maximum code value</param>
        /// <param name="match">The test value</param>
        [MethodImpl(Inline), Op]
        public static bit contains(C min, C max, C match)
            => match >= min && match <= max;
    }
}
