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
        public static IntrinsicsCatalog IntrinsicsCatalog(this IWfRuntime wf)
            => Svc.IntrinsicsCatalog.create(wf);

        [Op]
        public static XedCatalog XedCatalog(this IWfRuntime wf)
            => Svc.XedCatalog.create(wf);

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
        public static IntelSdmProcessor IntelSdmProcessor(this IWfRuntime wf)
            => Svc.IntelSdmProcessor.create(wf);

        [Op]
        public static DocServices DocServices(this IWfRuntime context)
            => Z0.DocServices.create(context);

    }
}