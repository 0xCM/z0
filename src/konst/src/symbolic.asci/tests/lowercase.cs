//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using C = AsciCharCode;

    partial struct AsciTest
    {
        /// <summary>
        /// Determines whether the source value is one of <see cref='AsciLetterLoCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit lowercase(C src)
            => contains((C)AsciLetterFacets.MinLowerCode, (C)AsciLetterFacets.MaxLowerCode, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciLetterLoCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit lowercase(char src)
            => lowercase((C)src);
    }
}
