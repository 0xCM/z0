//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Asci
    {
        /// <summary>
        /// Encodes a 2-character asci sequence
        /// </summary>
        /// <param name="a">The first asci code</param>
        /// <param name="b">The second asci code</param>
        [MethodImpl(Inline), Op]
        public static asci2 define(AsciCharCode a, AsciCharCode b)
            => new asci2(pack(a,b));

        /// <summary>
        /// Encodes a 3-character asci sequence
        /// </summary>
        /// <param name="a">The first asci code</param>
        /// <param name="b">The second asci code</param>
        /// <param name="c">The third asci code</param>
        [MethodImpl(Inline), Op]
        public static asci4 define(AsciCharCode a, AsciCharCode b, AsciCharCode c)
            => new asci4(pack(a, b, c, out var _ ));

        /// <summary>
        /// Encodes a 4-character asci sequence
        /// </summary>
        /// <param name="a">The first asci code</param>
        /// <param name="b">The second asci code</param>
        /// <param name="c">The third asci code</param>
        /// <param name="d">The fourth asci code</param>
        [MethodImpl(Inline), Op]
        public static asci4 define(AsciCharCode c0, AsciCharCode c1, AsciCharCode c2, AsciCharCode c3)
            => new asci4(pack(c0,c1,c2,c3, out var dst));
    }
}