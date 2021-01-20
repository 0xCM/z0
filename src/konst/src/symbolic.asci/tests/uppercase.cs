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
        /// Determines whether the source value is one of <see cref='AsciLetterUpCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit uppercase(C src)
            => contains((C)AsciLetterFacets.MinUpperCode, (C)AsciLetterFacets.MaxUpperCode, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciLetterUpCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit uppercase(char src)
            => uppercase((C)src);
    }
}
