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

    using static Root;
    
    readonly struct AsmArchiver :  IAsmArchiver
    {                
        public IAsmContext Context {get;}

        readonly DataResourceIndex Resources;

        [MethodImpl(Inline)]
        public static AsmArchiver Create(IAsmContext context)
            => new AsmArchiver(context);

        [MethodImpl(Inline)]
        AsmArchiver(IAsmContext context)
        {
            Context = context;
            Resources = Context.Compostion.FindCatalog(AssemblyId.Data).MapValueOrElse(c => c.Resources, () => DataResourceIndex.Empty);
        }

        IAssemblyComposition Resolved 
            => Context.Compostion;

        IEnumerable<AssemblyId> ActiveAssemblies
            => Context.ActiveAssemblies();

        Option<FilePath> ReportEmissions(AssemblyId src, AsmEmissionTokens<OpUri>[] emitted, AsmEmissionKind kind)
            => AsmReports.Emissions(src, emitted, kind).Save(AsmEmissionPaths.Current.EmissionPath(src, kind));

        AsmEmissionTokens<OpUri>[] EmitPrimary(in AsmCaptureExchange exchange, ICatalogProvider src,  IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionTokens<OpUri>>(); 

            void OnEmission(in AsmEmissionTokens<OpUri> emission) => emissions.Add(emission);            
            
            emitter.EmitPrimary(exchange,OnEmission);

            return emissions.ToArray();
        }        

        AsmEmissionTokens<OpUri>[] EmitImm(in AsmCaptureExchange exchange, ICatalogProvider src, IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionTokens<OpUri>>();   
            
            void OnEmission(in AsmEmissionTokens<OpUri> emission) => emissions.Add(emission);

            emitter.EmitImm(exchange,OnEmission);

            return emissions.ToArray();                
        }

        Option<FilePath> EmitLocations(ICatalogProvider src)
        {
            return AsmReports.MemberLocations(src.OwnerId, src.Owner).Save();
        }

        void Completed(Option<FilePath> report)
        {
            report.OnSome(p => term.inform($"Completed emission task and saved report to {p}"))
                  .OnNone(() => term.error($"Emission task failure"));
            report.Require();
        }

        void Archive(in AsmCaptureExchange exchange, ICatalogProvider src)
        {
            void OnEmission(in AsmEmissionTokens<OpUri> data)
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
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            var provider = Resolved.CatalogProvider(id);
            if(provider.IsSome())
            {
                var exchange = Context.CaptureExchange(OnCaptureEvent);
                Archive(in exchange, provider.Value);
            }
        }

        public void Execute()
        {             
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            var exchange = Context.CaptureExchange(OnCaptureEvent);
            var providers = Resolved.CatalogProviders(ActiveAssemblies);
            
            foreach(var src in providers)
                Archive(exchange, src);

            AsmReports.Resources(AssemblyId.Data, Resources).Save().Require();
        }
    }
}