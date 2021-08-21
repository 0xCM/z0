//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Llvm)]

namespace Z0.Parts
{
    public sealed class Llvm : Part<Llvm>
    {

    }
}

namespace Z0
{

    using Z0.llvm;

    public static class XSvc
    {

        [Op]
        public static LlvmObjDump LlvmObjDump(this IWfRuntime wf)
            => llvm.LlvmObjDump.create(wf);

        [Op]
        public static LlvmNm LlvmNm(this IWfRuntime wf)
            => llvm.LlvmNm.create(wf);
    }
}