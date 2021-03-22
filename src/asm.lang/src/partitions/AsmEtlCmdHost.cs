//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    using K = AsmEtlCmdKind;

    public sealed class AsmEltCmdHost : WfCmdHost<AsmEltCmdHost, AsmEtlCmdKind>
    {
        AsmCatalogEtl Catalog;

        protected override void OnInit()
        {
            Catalog = Wf.AsmCatalogEtl();
        }


        [Action(K.EmitFormCatalog)]
        void EmitFormCatalog()
            => Catalog.Emit(Catalog.KnownFormExpressions());
    }
}