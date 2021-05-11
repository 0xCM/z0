//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;
    public static partial class XSvc
    {
        public static ApiExtractor ApiExtracor(this IWfRuntime wf)
            => Z0.Asm.ApiExtractor.create(wf);
    }
}