//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial struct ApiQuery
    {
        public static ApiMethodG[] ImmGeneric(IApiHost host, RefinementClass kind)
            => generic(host).Where(op => op.Method.AcceptsImmediate(kind));
    }
}