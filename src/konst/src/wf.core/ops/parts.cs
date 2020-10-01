//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct WfCore
    {
        [MethodImpl(Inline), Op]
        public static PartId[] parts(string[] args, PartId[] fallback)
            => ApiPartIdParser.parse(args,fallback);
    }
}