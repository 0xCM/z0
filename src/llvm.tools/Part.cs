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
        public static LlvmEtlServices LlvmEtl(this IWfRuntime wf)
            => llvm.LlvmEtlServices.create(wf);

        [Op]
        public static LlvmPaths LlvmPaths(this IServiceContext context)
            => llvm.LlvmPaths.create(context);

        [Op]
        public static LlvmDb LlvmDb(this IWfRuntime wf)
            => llvm.LlvmDb.create(wf);

        [Op]
        public static ILlvmWorkspace LlvmWs(this IEnvProvider env)
            => Z0.LlvmWs.create(env.Env.LlvmRoot);

        [Op]
        public static LlvmToolbase LLvmToolbase(this IWfRuntime wf)
            => llvm.LlvmToolbase.create(wf);

        [Op]
        public static EtlCodeGen LlvmEtlCodeGen(this IWfRuntime wf)
            => llvm.EtlCodeGen.create(wf);
    }
}