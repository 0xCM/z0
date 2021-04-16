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
        StanfordAsmCatalog Catalog;

        protected override void OnInit()
        {
            Catalog = Wf.StanfordCatalog();
        }

        [Action(K.EmitResBytes)]
        public void EmitResBytes()
            => Wf.ResBytesEmitter().Emit();

        [Action(K.EmitApiClasses)]
        public void EmitApiClasses()
            => Wf.Symbolism().EmitApiClasses();

        [Action(K.EmitSymbolicLiterals)]
        public void EmitSymbolicLiterals()
            => Wf.Symbolism().Emit();

        [Action(K.ShowStandfordForms)]
        public void ShowStanfordForms()
        {
            using var writer = OpenShowLog("asm.forms");
            var forms = Catalog.KnownFormExpressions();
            var count = forms.Length;
            for(var i=0; i<count; i++)
                Show(skip(forms,i), writer);
        }

        [Action(K.ShowEncodingKindNames)]
        public void ShowEncodingKindNames()
            => root.iter(Catalog.EncodingKindNames(), Wf.Row);

        [Action(K.ExportStokeImports)]
        public void ExportStokeImports()
            => Catalog.ExportImport();

        [Action(K.EmitImmSpecializations)]
        public void EmitImmSpecializations()
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
            var blocks = Wf.ApiCatalogs().Correlate(catalogs);
        }

    }
}