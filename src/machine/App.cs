//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    class Machine : WfService<Machine>
    {
        CmdBuilder Commands;

        EtlSettings Options;

        protected override void OnInit()
        {
            Commands = Wf.CmdBuilder();
            Options = EtlSettings.@default();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.delimit(Wf.Api.PartIdentities));
            try
            {
                Wf.ApiServices().Correlate();

                if(Options.EmitAsmCatalogs)
                {
                    var etl = Wf.AsmCatalogEtl();
                    etl.ImportSource();
                    etl.ExportImport();
                }

                if(Options.EmitIntrinsicsInfo)
                    IntelIntrinsics.create(Wf).Emit();

                if(Options.EmitLiteralCatalogs)
                {
                    EmitFieldLiterals.create().Run(Wf);
                    Commands.EmitEnumCatalog().RunTask(Wf);
                    BitMaskServices.create(Wf).Emit();
                }

                if(Options.CollectApiDocs)
                {
                    EmitComments.create().Run(Wf);
                }

                if(Options.EmitResourceData)
                {
                    var resources = ResDataService.create(Wf);
                    resources.EmitContentIndex();
                    resources.EmitReferenceData();
                }

                if(Options.RunXed)
                {
                    using var xed = XedWf.create(Wf);
                    xed.Run();
                }

                var images = Wf.ImageDataEmitter();

                if(Options.EmitSectionHeaders)
                    images.EmitSectionHeaders();

                if(Options.EmitCilRecords)
                    images.EmitCilRecords();

                if(Options.EmitCliStrings)
                {
                    images.EmitUserStrings();
                    images.EmitSystemStrings();
                }

                if(Options.EmitCliConstants)
                    images.EmitConstants();

                if(Options.EmitCliBlobs)
                    images.EmitApiBlobs();

                if(Options.EmitImageContent)
                    root.iter(Wf.Api.PartComponents, c => images.EmitImageContent(c));

                var asm = Wf.AsmDataEmitter();

                if(Options.EmitAsmRows)
                    asm.EmitAsmRows();

                if(Options.EmitAsmAnalysis)
                    asm.EmitAnalyses();

                if(Options.EmitResBytes)
                    asm.EmitResBytes();

                if(Options.EmitStatements)
                    asm.EmitStatements();

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }

    struct App
    {
        public static void run(string[] args)
            => app(shell(args)).Run();

        static App app(IWfShell wf)
            => new App(wf);

        static IWfShell shell(string[] args)
            => WfShell.create(args).WithRandom(Rng.@default());

        IWfShell Wf;

        App(IWfShell wf)
        {
            Wf = wf;
        }

        void Run()
        {
            try
            {
                using var machine = Machine.create(Wf);
                machine.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public static void Main(params string[] args)
            => run(args);
    }

    public static partial class XTend {}
}