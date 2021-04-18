//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    using K = AsciWhitespaceCode;

    partial struct AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> whitespace()
            => recover<K,AsciCharCode>(Whitespace);

        static ReadOnlySpan<K> Whitespace
            => new K[]{K.CR, K.FF, K.NL, K.Space, K.Tab, K.VTab};
    }
}