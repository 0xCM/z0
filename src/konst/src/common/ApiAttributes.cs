//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiAttributes
    {
        public static OpKindId OpKindId(object id)
            => (OpKindId)(ulong)Convert.ChangeType(id, typeof(ulong));
    }
}