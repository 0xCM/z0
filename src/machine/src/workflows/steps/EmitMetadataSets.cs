//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static EmitMetadataSetsStep;

    public readonly ref struct EmitMetadataSets
    {
        public readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        public EmitMetadataSets(IWfContext context, CorrelationToken ct)
        {
            Wf = context;
            Ct = ct;
            Parts = ModuleArchives.executing().Parts.Array();
            Wf.Created(WorkerName, Ct);
        }

        void Run(EmitImageConstantsStep kind)
        {
            try
            {
                using var step = new EmitImageConstants(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitPeHeadersStep kind)
        {
            try
            {
                using var step = new EmitPeHeaders(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitPartCil kind)
        {
            try
            {
                using var step = new EmitPartCil(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitImageContentStep kind)
        {
            try
            {
                using var step = new EmitImageContent(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitStringRecordsStep kind)
        {
            try
            {
                using var step = new EmitStringRecords(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitImageBlobsStep kind)
        {
            try
            {
                using var step = new EmitImageBlobs(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitFieldMetadataStep kind)
        {
            try
            {
                using var step = new EmitFieldMetadata(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            Run(default(EmitImageConstantsStep));
            Run(default(EmitPeHeadersStep));
            Run(default(EmitPartCil));
            Run(default(EmitImageContentStep));
            Run(default(EmitStringRecordsStep));
            Run(default(EmitImageBlobsStep));
            Run(default(EmitFieldMetadataStep));
            Wf.Ran(WorkerName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}