//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiAttributes
    {
        public static ApiKeyId OpKindId(object id)
            => (ApiKeyId)(ulong)Convert.ChangeType(id, typeof(ulong));
    }
}