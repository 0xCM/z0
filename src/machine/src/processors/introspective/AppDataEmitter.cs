//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    using static Konst;
    using static Root;

    public readonly struct AppDataEmitter 
    {
        public static AppDataEmitter Service => default(AppDataEmitter);

        void EmitDocs(IAppContext app)
        {   
            Commented.collect();
        }

        void EmitResources(IAppContext app)
        {   
            HostCodeResources.Service(app).Emit();
        }

        void CaptureEmissions(IAppContext app)
        {
            var suite = ContextFactory.CreateClientContext(app);
            var ac = AccessorCapture.Service(suite.AsmContext);
            ac.CaptureResBytes();        
        }

        void EmitMetadata(IAppContext app)
        {   
            var service = MetadataEmitter.Service();
            service.Emit();
        }

        void EmitEnumDatasets(IAppContext app)
        {
            EnumDatasetEmitter.Service(app).Emit();
        }

        void Gen(IAppContext app)
        {
            ReflectedLiterals.emit(typeof(BitMasks), app.AppPaths);
            EmitMetadata(app);
            EmitDocs(app);
            EmitResources(app);
            CaptureEmissions(app);
            EmitEnumDatasets(app);
            new LiteralFieldEmitter(app).Emit();            
        }
        public CodeResourceIndex Load(IAppContext app)
        {
            var index = new CodeResourceIndex(Assembly.LoadFrom(app.AppPaths.ResBytes.Name));
            Root.iter(index.Hosts, h => term.print(h.DisplayName()));

            return index;

        }        
        public void Generate(IAppContext app)
        {     

            Gen(app);
        }
    }
}