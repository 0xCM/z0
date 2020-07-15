//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    public readonly struct AppDataEmitter 
    {
        public static AppDataEmitter Service 
            => default;

        static AppDataEmitterSteps Steps 
            => default;

        static void EmitDocs(IAppContext app)
            => Commented.collect();

        static void EmitResBytes(IAppContext app)
            => Steps.EmitResBytes.Configure(app).Run();

        static void CaptureEmissions(IAppContext app)
        {
            var suite = ContextFactory.CreateClientContext(app);
            var ac = new AccessorCapture(suite.AsmContext);
            ac.CaptureResBytes();        
        }

        static void EmitMetadata(IAppContext app)
            => MetadataEmitter.Service(app).Emit();

        static void EmitEnumDatasets(IAppContext app)
            => EnumDatasetEmitter.Service(app).Emit();

        static void All(IAppContext app)
        {
            term.magenta("Emitting bitmask data");
            ReflectedLiterals.emit(typeof(BitMasks), app.AppPaths);

            term.magenta("Emitting metadata");
            EmitMetadata(app);
            
            term.magenta("Emitting documentation");
            EmitDocs(app);

            term.magenta("Emitting resbytes");
            EmitResBytes(app);
            
            term.magenta("Capturing emissions");
            CaptureEmissions(app);            

            term.magenta("Emitting enum datasets");
            EmitEnumDatasets(app);

            term.magenta("Emitting literal fields");
            new LiteralFieldEmitter(app).Emit();                        
        }
                
        public static CodeResourceIndex Load(IAppContext app)
            => Resources.code(Assembly.LoadFrom(app.AppPaths.ResBytes.Name));
        
        public void Emit(IAppContext app)
            => EmitResBytes(app);
    }
}