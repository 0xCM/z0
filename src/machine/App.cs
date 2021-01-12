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

        internal Machine(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(typeof(Machine));
            Wf = wf.WithHost(Host);
            Asm = asm;
            Commands = Wf.CmdBuilder();
            Wf.Created();
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

                var resources = ResDataService.init(Wf);
                resources.EmitContentIndex();
                resources.EmitReferenceData();

                EmitComments.create().Run(Wf);

                XedEtlWfHost.create().Run(Wf);

                var images = ImageEmitters.init(Wf);
                images.EmitSectionHeaders();
                images.EmitCilRecords();
                images.EmitUserStrings();
                images.EmitSystemStrings();

                EmitFieldMetadata.create().Run(Wf);
                EmitImageConstants.create().Run(Wf);
                EmitLocatedParts.create().Run(Wf);
                EmitImageBlobs.create().Run(Wf);

                Commands.EmitEnumCatalog().Run(Wf);

                EmitFieldLiterals.create().Run(Wf);
                EmitBitMasks.create().Run(Wf);

                var processors = ApiProcessors.create(Wf, Asm);
                processors.EmitAsmRows();
                processors.EmitCallRows();
                processors.EmitJmpRows();
                processors.ProcessEnlisted();
                processors.EmitSemantic();
                processors.EmitResBytes();

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
            => app(wf(args)).Run();

        IWfShell Wf;

        IAsmContext Asm;

        App(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        static App app(IWfShell wf)
            => new App(wf, AsmWorkflows.context(wf));


        static IWfShell wf(string[] args)
            => WfShell.create(args).WithRandom(Rng.@default());

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