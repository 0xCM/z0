//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static IntrinsicsCatalog IntrinsicsCatalog(this IWfRuntime wf)
            => Asm.IntrinsicsCatalog.create(wf);

        [Op]
        public static XedCatalog XedCatalog(this IWfRuntime wf)
            => Asm.XedCatalog.create(wf);

        [Op]
        public static NasmCatalog NasmCatalog(this IWfRuntime wf)
            => Asm.NasmCatalog.create(wf);

        [Op]
        public static XedFormSplitter XedFormSplitter(this IWfRuntime wf)
            => Asm.XedFormSplitter.create(wf);
    }
}