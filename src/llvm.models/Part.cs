//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.LlvmModels)]
namespace Z0.Parts
{
    public sealed partial class LlvmModels : Part<LlvmModels>
    {

    }
}

namespace Z0
{
    using llvm;

    [ApiHost]
    public static partial class XTend
    {

    }

    public static class XSvc
    {
        public static LlvmDatasets LlvmDatasets(this IServiceContext context)
            => llvm.LlvmDatasets.create(context);

        public static llvm.Records LlvmRecords(this IServiceContext context)
            => llvm.Records.create(context);
    }
}