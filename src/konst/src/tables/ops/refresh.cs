//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static H refresh<H,T>(T[] data, H host = default)
            where T : struct
            where H : struct, ITableSpan<H,T>
                => host.Refresh(data);
    }
}