//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciCode;

    using CC = AsciCode;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bool eol(byte a0, byte a1)
            => (CC)a0 == CR || (CC)a1 == LF;

        [MethodImpl(Inline), Op]
        public static bool eol(char a, char b)
            => cr(a) && lf(b);

        /// <summary>
        /// Tests whether a 2-byte sequence represents the character '•'
        /// </summary>
        /// <param name="b0">The first byte</param>
        /// <param name="b1">The second byte</param>
        [MethodImpl(Inline), Op]
        public static bool bullet(byte b0, byte b1)
            => ((uint)b0 | (uint)b1 << 8) == CharValues.Bullet;
            //=> b0 == 0x20 && b1 == 0x22;
    }
}