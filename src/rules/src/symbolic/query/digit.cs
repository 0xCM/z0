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
    using F = DecimalSymFacet;

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Determines whether a code is one of <see cref='AsciDigitCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool digit(Base10 @base, C src)
            => contains(C.d0, C.d9, src);

        /// <summary>
        /// Determines whether the code of a specified character is one of <see cref='AsciDigitCode'/>
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool digit(Base10 @base, char src)
            => digit(base10, (C)src);

        [MethodImpl(Inline), Op]
        public static bool @decimal(char c)
            => (F)c >= F.First && (F)c <= F.Last;
    }
}