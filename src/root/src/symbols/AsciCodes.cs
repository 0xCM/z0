//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = AsciCharCode;

    [ApiHost]
    public readonly struct AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<K> whitespace()
            => Whitespace;

        static ReadOnlySpan<K> Whitespace
            => new K[]{K.CR, K.FF, K.LF, K.Space, K.Tab, K.VTab};
    }
}