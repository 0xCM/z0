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

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static uint length(ReadOnlySpan<C> src)
        {
            var counter = 0u;
            var max = (uint)src.Length;
            if(max == 0)
                return 0;
            for(var i=0u; i<max; i++)
            {
                if(skip(src,i) == 0)
                    return i;
            }
            return max;
        }

        /// <summary>
        /// Determines whether a specified code is one of <see cref='AsciLetterCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(C src)
            => lowercase(src) || uppercase(src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciLetterCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(char src)
            => letter((C)src);
    }
}