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
    using F = AsciCodeFacets;

    partial struct AsciTest
    {
        /// <summary>
        /// Determines whether a code is one of <see cref='AsciDigitCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit digit(C src)
            => contains(F.MinDigitCode, F.MaxDigitCode, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciDigitCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit digit(char src)
            => digit((C)src);
    }
}
