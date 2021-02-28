//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;


    class Machine : IDisposable
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        readonly CmdBuilder Commands;

        EtlSettings Options;

        internal Machine(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(typeof(Machine));
            Wf = wf.WithHost(Host);
            Asm = asm;
            Commands = Wf.CmdBuilder();
            Wf.Created();
            Options = EtlSettings.@default();
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.delimit(Wf.Api.PartIdentities));
            try
            {
                ApiCode.EmitHexIndex(Wf);

                if(Options.EmitAsmCatalogs)
                    AsmCatalogService.create(Wf).TransformSource();

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

                var images = ImageDataEmitter.create(Wf);

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


                if(Options.EmitPeData)
                    ImageLocationEmitter.emit(Wf);


                var asm = Wf.AsmDataEmitter();

                if(Options.EmitAsmRows)
                    asm.EmitAsmRows();

                if(Options.EmitAsmBranches)
                {
                    asm.EmitCallRows();
                    asm.EmitJmpRows();
                }

                if(Options.EmitAsmSemantic)
                    asm.EmitSemantic();

                if(Options.EmitResBytes)
                    asm.EmitResBytes();

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
            => new App(wf, AsmServices.context(wf));

        static IWfShell shell(string[] args)
            => WfShell.create(args).WithRandom(Rng.@default());

        IWfShell Wf;

        IAsmContext Asm;

        App(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        void Run()
        {
            try
            {
                using var machine = new Machine(Wf, Asm);
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