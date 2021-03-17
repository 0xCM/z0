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

    partial struct bit
    {
        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(bit src)
            => (BinaryDigit)(byte)src;
    }
}