//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct bit
    {
        [MethodImpl(Inline), Op]
        public static BinaryDigitValue digit(bit src)
            => (BinaryDigitValue)(byte)src;
    }
}