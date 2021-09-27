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
        public static EtlWorkflow LlvmEtl(this IWfRuntime wf)
            => llvm.EtlWorkflow.create(wf);

        [Op]
        public static LlvmPaths LlvmPaths(this IServiceContext context)
            => llvm.LlvmPaths.create(context);

        [Op]
        public static LlvmMc LLvmMc(this IWfRuntime wf)
            => llvm.LlvmMc.create(wf);

        public static ILlvmWorkspace LlvmWs(this IEnvProvider env)
            => Z0.LlvmWs.create(env.Env.LlvmRoot);

        [Op]
        public static LlvmToolbase LLvmToolbase(this IWfRuntime wf)
            => llvm.LlvmToolbase.create(wf);
    }
}