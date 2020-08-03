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
    using static Flow;
    using static EmitClrMetadataSetsStep;
    
    [Step(WfStepId.EmitClrMetadataSets, true)]
    public readonly struct EmitClrMetadataSetsStep
    {
        public const string WorkerName = nameof(EmitClrMetadataSets);
    }

    [Step(WfStepId.EmitClrMetadataSets)]
    public readonly ref struct EmitClrMetadataSets
    {
        public readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly FolderPath TargetRoot;
        
        readonly IPart[] Parts;

        readonly PartSink Sink;
        
        public EmitClrMetadataSets(WfContext context, CorrelationToken ct)
        {            
            Wf = context;
            Ct = ct;
            TargetRoot = AppPaths.Default.ResourceRoot;
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context.ContextRoot);
            Wf.Created(WorkerName, Ct);
        }
        
        void Run(EmitConstantDatasetsStep kind)
        {
            try
            {
                using var step = new EmitConstantDatasets(Wf, Parts, Ct);
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

        void Run(EmitCilDatasetsStep kind)
        {
            try
            {
                using var step = new EmitCilDatasets(Wf, Parts, Ct);
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

        void Run(EmitBlobsStep kind)
        {
            try
            {
                using var step = new EmitBlobs(Wf, Parts, Ct);
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
            Run(default(EmitConstantDatasetsStep));
            Run(default(EmitPeHeadersStep));
            Run(default(EmitCilDatasetsStep));                                    
            Run(default(EmitImageContentStep));  
            Run(default(EmitStringRecordsStep));
            Run(default(EmitBlobsStep));
            Run(default(EmitFieldMetadataStep));                        
            Wf.Ran(WorkerName, Ct);
        }        

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}