//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiAttributes
    {
        public static ApiKeyKind OpKindId(object id)
            => (ApiKeyKind)(ulong)Convert.ChangeType(id, typeof(ulong));
    }
}