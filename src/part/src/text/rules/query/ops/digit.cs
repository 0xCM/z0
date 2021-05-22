//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCharCode;

    partial struct TextQuery
    {
        /// <summary>
        /// Determines whether a code is one of <see cref='AsciDigitCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit digit(C src)
            => contains(C.d0, C.d9, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciDigitCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit digit(char src)
            => digit((C)src);
    }
}