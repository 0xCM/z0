//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.LlvmTools)]

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

        [Op]
        public static LlvmEtl LlvmEtl(this IWfRuntime wf)
            => llvm.LlvmEtl.create(wf);

        [Op]
        public static OmniScript OmniScript(this IWfRuntime wf)
            => Z0.OmniScript.create(wf);

    }
}