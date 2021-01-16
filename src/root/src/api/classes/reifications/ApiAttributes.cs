//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiAttributes
    {
        public static ApiClass OpKindId(object id)
            => (ApiClass)(ulong)Convert.ChangeType(id, typeof(ulong));
    }
}