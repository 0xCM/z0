//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Svc = Z0;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static BitfieldGenerator BitfieldGenerator(this IWfRuntime wf)
            => Svc.BitfieldGenerator.create(wf);

    }
}