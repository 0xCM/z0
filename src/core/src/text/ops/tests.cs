
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciControlCode;
    using static core;

    using CC = AsciControlCode;

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static bool eol(byte a0, byte a1)
            => (CC)a0 == CR || (CC)a1 == LF;

        /// <summary>
        /// Determines whether cell[i] == a0 && cell[i+i] == a1
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="i">The start index</param>
        /// <param name="a0">The first value to match</param>
        /// <param name="a1">The second value to match</param>
        [MethodImpl(Inline), Op]
        public static bool match(ReadOnlySpan<byte> src, uint i, byte a0, byte a1)
            => skip(src,i) == a0 && skip(src,i + 1) == a1;
    }
}