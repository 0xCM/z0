//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    public readonly partial struct AppDataEmitter 
    {
        readonly IAppContext Context;
        
        public AppDataEmitter(IAppContext context)
        {
            Context = context;
        }
        
        public static AppDataEmitter Service(IAppContext context) 
            => new AppDataEmitter(context);

        void ExecEmitDocs()
        {
            new EmitDocs(this).Run();
        }

        void EmitResBytes()
        {
            term.magenta("Emitting resbytes");
            var step = new EmitResBytes();
            step.Configure(Context).Run();
        }

        void CaptureEmissions()
        {
            term.magenta("Capturing emissions");
            var suite = ContextFactory.CreateClientContext(Context);
            var ac = new AccessorCapture(suite.AsmContext);
            ac.CaptureResBytes();        
        }

        void EmitMetadata()
        {
            term.magenta("Emitting metadata");                 
            MetadataEmitter.Service(Context).Emit();
            term.magenta("Emitted metadata");                 
        }

        void EmitEnumDatasets()
        {
            term.magenta("Emitting enum datasets");
            EnumDatasetEmitter.Service(Context).Emit();
            term.magenta("Emitted enum datasets");
        }
        
        void EmitLiterals()
        {
            term.magenta("Emitting literal fields");
            new LiteralFieldEmitter(Context).Run();                        
            term.magenta("Emitted literal fields");
        }

        void EmitBitMasks()
        {
            term.magenta("Emitting bitmask data");
            ReflectedLiterals.emit(typeof(BitMasks), Context.AppPaths);
            term.magenta("Emitted bitmask data");
        }
                        
        public CodeResourceIndex Load()
            => Resources.code(Assembly.LoadFrom(Context.AppPaths.ResBytes.Name));
        
        public void Run(params string[] args)
        {
            EmitBitMasks();
            EmitMetadata();        
            ExecEmitDocs();
            EmitResBytes();            
            CaptureEmissions();            
            EmitEnumDatasets();
            EmitLiterals();
        }
    }
}