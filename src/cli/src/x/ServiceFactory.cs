//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XSvc
    {
        public static CliDataPipe CliDataPipe(this IWfRuntime wf)
            => Z0.CliDataPipe.create(wf);

        public static MsilPipe MsilPipe(this IWfRuntime wf)
            => Z0.MsilPipe.create(wf);
    }
}