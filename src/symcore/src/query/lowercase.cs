//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCode;
    using F = AsciFacets;

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Determines whether the source value is one of <see cref='AsciLetterLoCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool lowercase(C src)
            => contains(F.MinLowerCode, F.MaxLowerCode, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciLetterLoCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool lowercase(char src)
            => lowercase((C)src);
    }
}
