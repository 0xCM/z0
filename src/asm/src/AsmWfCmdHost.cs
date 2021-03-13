//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static WfCmd;
    using static memory;
    using static Asm.AsmOpCodesLegacy;

    using K = AsmWfCmdKind;

    public sealed class AsmWfCmdHost : WfCmdHost<AsmWfCmdHost, AsmWfCmdKind>
    {
        ApiServices ApiServices;

        AsmCatalogEtl Catalog;

        Lazy<AsmDataEmitter> _DataEmitter;

        AsmDataEmitter DataEmitter
        {
            get => _DataEmitter.Value;
        }

        protected override void OnInit()
        {
            Catalog = Wf.AsmCatalogEtl();
            ApiServices = Wf.ApiServices();
            _DataEmitter = root.lazy(Wf.AsmDataEmitter);
        }

        [Action(K.EmitResBytes)]
        void EmitResBytes()
            => Wf.ResBytesEmitter().Emit();

        [Action(K.EmitApiClasses)]
        void EmitApiClasses()
            => ApiServices.EmitApiClasses();

        [Action(K.EmitSymbolicLiterals)]
        void EmitSymbolicLiterals()
            => ApiServices.EmitSymbolicLiterals();


        [Action(K.ShowAsmCatForms)]
        void ShowAsmCatForms()
        {
            var specifiers = Catalog.CatalogedForms();
            var count = specifiers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specifiers,i);
                Wf.Row(spec.Format());
            }
        }

        [Action(K.EmitAsmCatForms)]
        void EmitAsmCatForms()
            => Catalog.Emit(Catalog.CatalogedForms());

        [Action(K.ShowEncodingKindNames)]
        void ShowEncodingKindNames()
            => root.iter(Catalog.EncodingKindNames(), Wf.Row);

        [Action(K.ExportStokeImports)]
        void ExportStokeImports()
            => Catalog.ExportImport();

        [Action(K.DistillAsmStatements)]
        void DistillAsmStatements()
            => Wf.AsmDistiller().DistillStatements();

        [Action(K.ShowRexBits)]
        void ShowRexBits()
        {
            var codes = Rex.bits();
            var count = codes.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(codes,i);
                Wf.Row(code.Format());
            }
        }

        [Action(K.EmitImmSpecializations)]
        void EmitImmSpecializations()
            => Wf.ImmEmitter().Emit();

        [Action(K.EmitAsmRows)]
        void EmitAsmRows()
            => DataEmitter.EmitAsmRows();

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

        [Action(K.EmitLegacyOpCodes)]
        void EmitLegacyOpCodes()
        {
            var data = dataset().Entries;
            var count = data.Count;
            var view = data.View;
            var formatter = formatter<AsmOpCodeField>();
            var rowbuffer = alloc<AsmOpCodeRowLegacy>(count);
            var rows = span(rowbuffer);
            var path = Db.IndexTable<AsmOpCodeRowLegacy>();
            using var dst = path.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                seek(rows,i) = record;

                format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
        }
    }
}