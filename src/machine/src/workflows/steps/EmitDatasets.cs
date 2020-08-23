//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static Konst;
    using static EmitDatasetsStep;

    public ref partial struct EmitDatasets
    {
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly bool Recapture;

        public EmitDatasets(IWfContext context, CorrelationToken ct)
        {
            Ct = ct;
            Wf = context;
            Recapture = false;
            Wf.Initialized(StepName, Ct);
        }

        void Run(EmitProjectDocsStep kind)
        {
            try
            {
                using var step = new EmitProjectDocs(Wf, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }


        public void Dispose()
        {
            Wf.Finished(nameof(EmitDatasets), Ct);
        }

        void Run(EmitResBytesStep kind)
        {
            using var step = new EmitResBytes(Wf, Ct);
            step.Run();
        }


        void Run(EmitMetadataSetsStep kind)
        {
            using var step = new EmitMetadataSets(Wf, Ct);
            step.Run();
        }

        void Run(EmitEnumCatalogStep kind)
        {
            using var step = new EmitEnumCatalog(Wf, Ct);
            step.Run();
        }

        void Run(EmitFieldLiteralsStep kind)
        {
            using var step = new EmitFieldLiterals(Wf, Ct);
            step.Run();
        }

        void Run(EmitContentCatalogStep kind)
        {
            using var step = new EmitContentCatalog(Wf, Ct);
            step.Run();
        }

        void Run(EmitBitMasksStep kind)
        {
            using var step = new EmitBitMasks(Wf, Ct);
            step.Run();
        }

        public void Run()
        {
            Run(default(EmitMetadataSetsStep));
            Run(default(EmitBitMasksStep));
            Run(default(EmitProjectDocsStep));
            Run(default(EmitResBytesStep));
            Run(default(EmitEnumCatalogStep));
            Run(default(EmitFieldLiteralsStep));
            Run(default(EmitContentCatalogStep));
        }

        [MethodImpl(Inline), Op]
        public static IAsmContext asm(IAppContext root)
            => new AsmContext(root);

        void Run(RecaptureStep kind)
        {
            var resources = Resources.code(Assembly.LoadFrom(Wf.ResPack.Name));
            using var step = new Recapture(asm(Wf.ContextRoot));
            step.CaptureResBytes();
        }
    }
}