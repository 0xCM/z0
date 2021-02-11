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

                var resources = ResDataService.create(Wf);
                resources.EmitContentIndex();
                resources.EmitReferenceData();
                EmitComments.create().Run(Wf);
                AsmCatalogEtl.create(Wf).TransformSource();

                //XedEtlWfHost.create().Run(Wf);

                var images = ImageDataEmitter.create(Wf);
                images.EmitSectionHeaders();
                images.EmitCilRecords();
                images.EmitUserStrings();
                images.EmitSystemStrings();
                images.EmitConstants();
                images.EmitApiBlobs();

                EmitFieldMetadata.create().Run(Wf);
                EmitLocatedParts.create().Run(Wf);

                Commands.EmitEnumCatalog().RunTask(Wf);

                EmitFieldLiterals.create().Run(Wf);
                BitMaskServices.create(Wf).Emit();

                AsmDataEmitter.create(Wf).Run();

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