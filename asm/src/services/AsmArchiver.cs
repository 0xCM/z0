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
            Resources = Context.Compostion.FindCatalog(AssemblyId.Data).MapValueOrElse(c => c.Resources, () => DataResourceIndex.Empty);
        }

        IAssemblyComposition Resolved 
            => Context.Compostion;

        IEnumerable<AssemblyId> ActiveAssemblies
            => Context.ActiveAssemblies();

        Option<FilePath> ReportEmissions(AssemblyId src, CaptureTokenGroup[] emitted, AsmEmissionKind kind)
            => AsmReports.Emissions(src, emitted, kind).Save();

        CaptureTokenGroup[] EmitPrimary(in CaptureExchange exchange, ICatalogProvider src,  IAsmCatalogEmitter emitter)
        {
            var emissions = new List<CaptureTokenGroup>(); 

            void OnEmission(in CaptureTokenGroup emission) => emissions.Add(emission);            
            
            emitter.EmitPrimary(exchange,OnEmission);

            return emissions.ToArray();
        }        

        CaptureTokenGroup[] EmitImm(in CaptureExchange exchange, ICatalogProvider src, IAsmCatalogEmitter emitter)
        {
            var emissions = new List<CaptureTokenGroup>();   
            
            void OnEmission(in CaptureTokenGroup emission) => emissions.Add(emission);

            emitter.EmitImm(exchange,OnEmission);

            return emissions.ToArray();                
        }

        Option<FilePath> EmitLocations(ICatalogProvider src)
        {
            return AsmReports.MemberLocations(src.OwnerId, src.Owner).Save();
        }

        void Completed(Option<FilePath> report)
        {
            report.OnSome(p => print(appMsg($"Completed emission task and saved report to {p}")))
                  .OnNone(() => error($"Emission task failure"));
            report.Require();
        }

        void Archive(in CaptureExchange exchange, ICatalogProvider src)
        {
            void OnEmission(in CaptureTokenGroup data)
            {

            }

            var metadata = src.Owner.CreateIndex();
            var context = AsmContext.New(metadata, Resources);
            var emitter = context.CatalogEmitter(src.Operations, OnEmission);

            var primary = EmitPrimary(exchange, src, emitter);
            if(primary.Length != 0)
                Completed(ReportEmissions(src.OwnerId, primary, AsmEmissionKind.Primary));
            
            var imm = EmitImm(exchange, src, emitter);
            if(imm.Length != 0)
                Completed(ReportEmissions(src.OwnerId, imm, AsmEmissionKind.Imm));
            
            Completed(EmitLocations(src));
        }

        public void Archive(AssemblyId id)
        {
            void OnCaptureEvent(in CaptureEventData data)
            {

            }

            var provider = Resolved.CatalogProvider(id);
            if(provider.IsSome())
            {
                var exchange = CaptureServices.Exchange(OnCaptureEvent);
                Archive(in exchange, provider.Value);
            }
        }

        public void Execute()
        {             
            void OnCaptureEvent(in CaptureEventData data)
            {

            }

            var exchange = CaptureServices.Exchange(OnCaptureEvent);
            var providers = Resolved.CatalogProviders(ActiveAssemblies);
            
            foreach(var src in providers)
                Archive(exchange, src);

            AsmReports.Resources(AssemblyId.Data, Resources).Save().Require();
        }
    }
}