//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public struct MachineOptions
    {
        public bool RunXed;

        public bool EmitResourceData;

        public bool CollectApiDocs;

        public bool EmitPeData;

        public bool EmitSectionHeaders;

        public bool EmitCilRecords;

        public bool EmitCliStrings;

        public bool EmitCliBlobs;

        public bool EmitCliConstants;

        public bool EmitLiteralCatalogs;

        public bool EmitAsmCatalogs;

        public bool EmitAsmSemantic;

        public bool EmitAsmRows;

        public bool EmitResBytes;

        public bool EmitAsmBranches;

        public static MachineOptions @default()
        {
            var dst = new MachineOptions();
            dst.RunXed = false;
            dst.EmitResourceData = false;
            dst.CollectApiDocs = false;
            dst.EmitPeData = true;
            dst.EmitSectionHeaders = true;
            dst.EmitCilRecords = true;
            dst.EmitCliStrings = true;
            dst.EmitCliBlobs = true;
            dst.EmitCliConstants = true;
            dst.EmitLiteralCatalogs = true;
            dst.EmitAsmCatalogs = true;
            dst.EmitAsmSemantic = false;
            dst.EmitAsmRows = true;
            dst.EmitResBytes = true;
            dst.EmitAsmBranches = true;
            return dst;
        }
    }

    class Machine : IDisposable
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        readonly CmdBuilder Commands;

        MachineOptions Options;

        internal Machine(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(typeof(Machine));
            Wf = wf.WithHost(Host);
            Asm = asm;
            Commands = Wf.CmdBuilder();
            Wf.Created();
            Options = MachineOptions.@default();
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
                    XedEtlWfHost.create().Run(Wf);

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