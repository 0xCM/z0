//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static string utf8(in ResDescriptor src)
            => Encoded.utf8(view(src));
    }
}