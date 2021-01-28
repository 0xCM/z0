//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Credits
    {
        [MethodImpl(Inline), Op]
        public static ContentRef page(ushort n)
            => new ContentRef(bit.set(n, 15, bit.On));
    }
}