//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Svc = Z0.Asm;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static IntelIntrinsics IntelIntrinsics(this IWfRuntime wf)
            => Svc.IntelIntrinsics.create(wf);

        [Op]
        public static IntelSdmProcessor IntelSdmProcessor(this IWfRuntime wf)
            => Svc.IntelSdmProcessor.create(wf);

        [Op]
        public static IntelXed IntelXed(this IWfRuntime wf)
            => Svc.IntelXed.create(wf);

        [Op]
        public static NasmCatalog NasmCatalog(this IWfRuntime wf)
            => Svc.NasmCatalog.create(wf);

        [Op]
        public static XedFormPipe XedFormPipe(this IWfRuntime wf)
            => Svc.XedFormPipe.create(wf);

        [Op]
        public static AsmCatalogs AsmCatalogs(this IWfRuntime wf)
            => Svc.AsmCatalogs.create(wf);

        [Op]
        public static DocServices DocServices(this IWfRuntime context, DocProcessArchive archive)
            => Z0.DocServices.create(context).WithArchive(archive);
    }
}