//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    using K = AsmWfCmdKind;

    public sealed class AsmWfCmdHost : WfCmdHost<AsmWfCmdHost, AsmWfCmdKind>
    {
        ApiServices ApiServices;

        AsmCatalogEtl Catalog;

        protected override void OnInit()
        {
            Catalog = Wf.AsmCatalogEtl();
            ApiServices = Wf.ApiServices();
        }

        [Action(K.EmitResBytes)]
        void EmitResBytes()
            => Wf.ResBytesEmitter().Emit();

        [Action(K.EmitApiClasses)]
        void EmitApiClasses()
            => Wf.SymLiterals().EmitApiClasses();

        [Action(K.EmitSymbolicLiterals)]
        void EmitSymbolicLiterals()
            => Wf.SymLiterals().Emit();

        [Action(K.ShowFormCatalog)]
        void ShowFormCatalog()
        {
            using var writer = OpenShowLog("asm.forms");
            var forms = Catalog.KnownFormExpressions();
            var count = forms.Length;
            for(var i=0; i<count; i++)
                Show(skip(forms,i), writer);
        }

        [Action(K.ShowEncodingKindNames)]
        void ShowEncodingKindNames()
            => root.iter(Catalog.EncodingKindNames(), Wf.Row);

        [Action(K.ExportStokeImports)]
        void ExportStokeImports()
            => Catalog.ExportImport();


        [Action(K.EmitImmSpecializations)]
        void EmitImmSpecializations()
            => Wf.ImmEmitter().Emit();

        [Action(K.CheckDigitParser)]
        void CheckDigitParser()
        {
            var cases = DigitParserCases.positive();
            var results = DigitParserCases.run(cases).View;
            var count = results.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var result = ref skip(results,i);
                if(result.Passed)
                    Wf.Status(result.Format());
                else
                    Wf.Error(result.Format());
            }
        }

        [Action(K.CorrelateApiCode)]
        void CorrelateApiCode()
        {
            var catalogs = Wf.Api.PartCatalogs();
            var blocks = ApiServices.Correlate(catalogs);
            // var flow = Wf.Running("Evaluator");
            // var evaluate = Evaluate.control(Wf, Rng.@default(), Wf.Paths.AppCaptureRoot, Pow2.T14);
            // evaluate.Execute(Wf.Api.PartIdentities);
            // Wf.Ran(flow);
        }

    }
}