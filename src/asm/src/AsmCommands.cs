//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public sealed class AsmCommands : AppService<AsmCommands>
    {
        StanfordAsmCatalog Catalog;

        protected override void OnInit()
        {
            Catalog = Wf.StanfordCatalog();
        }

        public void EmitResBytes()
            => Wf.ResPackEmitter().Emit();

        public void EmitApiClasses()
        {
            var dst = Db.IndexTable("api.classes");
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var literals = Wf.ApiQuery().ApiClassLiterals();
            var count = Tables.emit(literals, dst);
            Wf.EmittedTable(flow, count);
        }

        public void ShowStanfordForms()
        {
            using var writer = OpenShowLog("asm.forms");
            var forms = Catalog.KnownFormExpressions();
            var count = forms.Length;
            for(var i=0; i<count; i++)
                Show(skip(forms,i), writer);
        }

        public void CheckDigitParser()
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
    }
}