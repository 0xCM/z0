//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Reflection;
    
    using static Konst;

    public ref partial struct EmitDatasets  
    {
        public readonly WfContext Context;

        readonly CorrelationToken Correlation;
        
        readonly bool Recapture;

        readonly string[] Args;

        public EmitDatasets(WfContext context, params string[] args)
        {
            Args = args;
            Context = context;
            Recapture = false;
            Correlation = CorrelationToken.create();
            Context.Running(nameof(EmitDatasets), Correlation);
        }
        
        void ExecEmitDocs()
        {
            using var step = new EmitProjectDocs(Context, Correlation);
            step.Run();
        }

        void EmitBytes()
        {
            using var step = EmitResBytes.create(Context, Correlation);
            step.Run();
        }

        void CaptureEmissions()
        {
            var capture = ContextFactory.WfCapture(Context);
            using var step = new AccessorCapture(capture);
            step.CaptureResBytes();        
        }

        void EmitMetadata()
        {
            using var step = new EmitMetadataSets(Context, Correlation);
            step.Run();
        }

        void EmitEnumDatasets()
        {
            using var step = new EmitEnumData(Context, Correlation);
            step.Run();
        }
        
        void EmitLiterals()
        {
            using var step = new EmitFieldLiterals(Context);
            step.Run();

        }

        void EmitCatalog()
        {
            using var step = new EmitContentCatalog(Context);
            step.Run();
        }

        void EmitBitMasks()
        {
            using var step = new EmitBitMasks(Context);
            step.Run();
        }
                        
        public CodeResourceIndex Load()
            => Resources.code(Assembly.LoadFrom(Context.AppPaths.ResBytes.Name));
        
        public void Run(params string[] args)
        {
            EmitBitMasks();
            EmitMetadata();        
            ExecEmitDocs();
            EmitBytes();            
            //CaptureEmissions();            
            EmitEnumDatasets();
            EmitLiterals();
            EmitCatalog();
        }
 
        public void Dispose()
        {
            Context.Ran(nameof(EmitDatasets), Correlation);
        }
    }
}