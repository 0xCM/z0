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
    
    readonly struct AsmArchiver :  IAsmArchiver
    {                
        public IAsmContext Context {get;}

        readonly DataResourceIndex Resources;

        public static AsmArchiver Create(IAsmContext context)
            => new AsmArchiver(context);

        AsmArchiver(IAsmContext context)
        {
            Context = context;
            Resources = Context.Assemblies.FindCatalog(AssemblyId.Data).Require().Resources;
        }

        IAssemblyComposition Resolved 
            => Context.Assemblies;

        IEnumerable<AssemblyId> ActiveAssemblies
            => Context.ActiveAssemblies();

        Option<FilePath> ReportEmissions(AssemblyId src, AsmEmissionGroup[] emitted, AsmEmissionKind kind)
            => AsmReports.Emissions(src, emitted, kind).Save();

        AsmEmissionGroup[] EmitPrimary(in CaptureExchange exchange, IOperationProvider src,  IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionGroup>(); 

            void OnEmission(AsmEmissionGroup emission)
                => emissions.Add(emission);            
            
            emitter.EmitPrimary(exchange,OnEmission);

            return emissions.ToArray();
        }        

        AsmEmissionGroup[] EmitImm(in CaptureExchange exchange, IOperationProvider src, IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionGroup>();   
            
            void OnEmission(AsmEmissionGroup emission)
                => emissions.Add(emission);

            emitter.EmitImm(exchange, OnEmission);

            return emissions.ToArray();                
        }

        Option<FilePath> EmitLocations(IOperationProvider src)
        {
            return AsmReports.MemberLocations(src.HostId, src.HostAssembly).Save();
        }

        void Completed(Option<FilePath> report)
        {
            report.OnSome(p => print(appMsg($"Completed emission task and saved report to {p}")))
                  .OnNone(() => errout($"Emission task failure"));
            report.Require();
        }

        void Archive(in CaptureExchange exchange, IOperationProvider src)
        {
            var metadata = ClrMetadataIndex.Create(src.HostAssembly);
            var context = AsmContext.New(metadata, Resources);
            var emitter = context.CatalogEmitter(src.Catalog);

            var primary = EmitPrimary(exchange, src, emitter);
            if(primary.Length != 0)
                Completed(ReportEmissions(src.HostId, primary, AsmEmissionKind.Primary));
            
            var imm = EmitImm(exchange, src, emitter);
            if(imm.Length != 0)
                Completed(ReportEmissions(src.HostId, imm, AsmEmissionKind.Imm));

            
            Completed(EmitLocations(src));
        }

        public void Archive(AssemblyId id)
        {
            var provider = Resolved.OperationProvider(id);
            if(provider.IsSome())
            {
                var exchange = CaptureServices.Exchange();
                Archive(in exchange, provider.Value);
            }
        }

        public void Execute()
        {             
            var control = CaptureServices.Control();
            var exchange = CaptureServices.Exchange(control);
            var providers = Resolved.OperationProviders(ActiveAssemblies);
            
            foreach(var src in providers)
                Archive(exchange, src);

            AsmReports.Resources(AssemblyId.Data, Resources).Save().Require();
        }
    }
}