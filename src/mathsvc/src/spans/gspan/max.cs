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

    partial class gspan
    {
        /// <summary>
        /// Finds a numeric cell of maximal value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Max, Closures(AllNumeric)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;

            ref readonly var input = ref first(src);
            var result = input;

            for(var i=1; i<count; i++)
            {
                ref readonly var test = ref skip(input, i);
                if(gmath.gt(test, result))
                    result = test;
            }

            return result;
        }
    }
}