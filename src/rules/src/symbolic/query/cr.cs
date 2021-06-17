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

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bit cr(C src)
            => C.CR == src;

        /// <summary>
        /// Tests whether a source character is a <see cref='AsciChar.CR'/>
        /// </summary>
        /// <param name="src">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bit cr(char src)
            => (char)C.CR == src;
    }
}