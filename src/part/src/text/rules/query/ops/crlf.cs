//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct TextQuery
    {
        /// <summary>
        /// Tests whether the first <see cref='char'/> is a <see cref='AsciChar.CR'/> and the second <see cref='char'/> is a <see cref='AsciChar.LF'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool crlf(char a, char b)
            => cr(a) && lf(b);
    }
}