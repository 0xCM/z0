//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiAttributes
    {
        public static ApiOpId OpKindId(object id)
            => (ApiOpId)(ulong)Convert.ChangeType(id, typeof(ulong));
    }
}