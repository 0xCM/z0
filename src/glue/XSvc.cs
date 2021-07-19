//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;
    using Z0.Tools;

    using static core;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static DocServices DocServices(this IWfRuntime context)
            => Asm.DocServices.create(context);

        [Op]
        public static IntelSdmProcessor IntelSdmProcessor(this IWfRuntime wf)
            => Asm.IntelSdmProcessor.create(wf);

        [Op]
        public static IntelIntrinsics IntelIntrinsicsPipe(this IWfRuntime wf)
            => Asm.IntelIntrinsics.create(wf);

        [Op]
        public static IntelXed IntelXed(this IWfRuntime wf)
            => Asm.IntelXed.create(wf);

        [Op]
        public static NasmCatalog NasmCatalog(this IWfRuntime wf)
            => Asm.NasmCatalog.create(wf);

        [Op]
        public static Nasm Nasm(this IWfRuntime wf)
            => Tools.Nasm.create(wf);

        [Op]
        public static NDisasm NDisasm(this IWfRuntime wf)
            => Tools.NDisasm.create(wf);

        public static DumpParser DumpParser(this IWfRuntime wf)
            => Z0.DumpParser.create(wf);

        [Op]
        public static Robocopy Robocopy(this IWfRuntime wf)
            => Tools.Robocopy.create(wf);

        [Op]
        public static CultProcessor CultProcessor(this IWfRuntime wf)
            => Tools.CultProcessor.create(wf);

        [Op]
        public static DumpBin DumpBin(this IWfRuntime wf)
            => Tools.DumpBin.create(wf);

        [Op]
        public static XedTool XedTool(this IWfRuntime wf)
            => Tools.XedTool.create(wf);

        [Op]
        public static BdDisasm BdDisasm(this IServiceContext ctx)
            => Tools.BdDisasm.create(ctx);

        public static Index<IToolResultHandler> ResultHandlers(this IEnvPaths paths)
        {
            var buffer = sys.alloc<IToolResultHandler>(2);
            ref var dst = ref first(buffer);
            seek(dst,0) = new MsBuildResultHandler(paths);
            seek(dst,1) = new RobocopyResultHandler(paths);
            return buffer;
        }

        [Op]
        public static XedTableParser XedTableParser(this IWfRuntime wf)
            => Tools.XedTableParser.create(wf);
    }
}