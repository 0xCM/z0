//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    
    readonly struct AsmArchiveControl :  IAsmService, IExecutable
    {                
        public IAsmContext Context {get;}

        readonly DataResourceIndex Resources;

        public static AsmArchiveControl Create(IAsmContext context)
            => new AsmArchiveControl(context);

        AsmArchiveControl(IAsmContext context)
        {
            Context = context;
            Resources = Context.Assemblies.FindCatalog(AssemblyId.Data).Require().Resources;
        }

        IAssemblyComposition Resolved 
            => Context.Assemblies;

        IEnumerable<AssemblyId> ActiveAssemblies
            => Context.ActiveAssemblies();

        Option<FilePath> EmitPrimary(in CaptureExchange exchange, IOperationProvider src,  IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionGroup>();   
            void OnEmission(AsmEmissionGroup emission)
                => emissions.Add(emission);            
            
            emitter.EmitPrimary(exchange,OnEmission);

            var emitted = emissions.ToArray();

            if(emitted.Length != 0)    
                return AsmReports.CreateEmissionReport(src.HostId, emitted).Save();
            else
                return none<FilePath>();
        }

        Option<FilePath> EmitImm(in CaptureExchange exchange, IOperationProvider src, IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionGroup>();   
            void OnEmission(AsmEmissionGroup emission)
                => emissions.Add(emission);

            emitter.EmitImm(exchange,OnEmission);

            var emitted = emissions.ToArray();                
            if(emitted.Length != 0)                
                return AsmReports.CreateEmissionReport(src.HostId, emitted, IDI.Imm).Save();
            else
                return none<FilePath>();
        }

        Option<FilePath> EmitLocations(IOperationProvider src)
        {
            return AsmReports.CreateMemberLocationReport(src.HostId, src.HostAssembly).Save();
        }

        void Completed(Option<FilePath> report)
        {
            report.OnSome(p => print(appMsg($"Completed emission task and saved report to {p}")))
                  .OnNone(() => errout($"Emission task failure"));
            report.Require();
        }

        void Emit(in CaptureExchange exchange, IOperationProvider src)
        {
            var metadata = ClrMetadataIndex.Create(src.HostAssembly);
            var context = AsmContext.New(metadata, Resources);
            var emitter = context.CatalogEmitter(src.Catalog);      
            
            Completed(EmitPrimary(exchange, src, emitter));
            Completed(EmitImm(exchange, src, emitter));
            Completed(EmitLocations(src));
        }

        public void Execute()
        {             
            var control = CaptureServices.Control();
            var exchange = CaptureServices.Exchange(control);
            var providers = Resolved.OperationProviders(ActiveAssemblies);
            
            foreach(var src in providers)
                Emit(exchange, src);

            AsmReports.CreateResourceReport(Resources).Save().Require();
        }
    }
}