//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Z0.llvm;

    public static partial class XSvc
    {
        public static LlvmDatasets LlvmDatasets(this IServiceContext context, IWorkspace sources)
            => llvm.LlvmDatasets.create(context).WithSource(sources);
    }
}
