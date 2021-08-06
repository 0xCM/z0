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
    using F = AsciCodeFacets;

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Determines whether the source value is one of <see cref='AsciLetterUpCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit uppercase(C src)
            => contains(F.MinUpperLetter, F.MaxUpperLetter, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciLetterUpCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit uppercase(char src)
            => contains((char)F.MinUpperLetter, (char)F.MaxUpperLetter, src);
    }
}