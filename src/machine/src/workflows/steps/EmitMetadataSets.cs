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
        public readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        public EmitMetadataSets(IWfShell context)
        {
            Wf = context;
            Ct = context.Ct;
            Parts = Wf.Api.Parts;
            Wf.Created(StepId, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);
            Run(default(EmitImageConstantsStep));
            Run(default(EmitPeHeadersStep));
            Run(default(EmitPartCil));
            Run(default(EmitImageContentStep));
            Run(default(EmitStringRecordsStep));
            Run(default(EmitImageBlobsStep));
            Run(default(EmitFieldMetadataStep));
            Wf.Ran(StepId);
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
                Wf.Error(kind.GetType(), e);
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
                Wf.Error(kind.GetType(), e);
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
                Wf.Error(typeof(EmitPartCil), e);
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
                Wf.Error(kind.GetType(), e);
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
                Wf.Error(kind.GetType(), e);
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
                Wf.Error(kind.GetType(), e);
            }
        }
    }
}