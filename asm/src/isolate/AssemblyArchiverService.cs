//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static AsmWorkflowReports;
    
    readonly struct AssemblyArchiverService :  IAsmAssemblyArchiver
    {                
        readonly IAsmContext Context;

        readonly BinaryResources Resources;

        [MethodImpl(Inline)]
        static AssemblyArchiverService Create(IAsmContext context)
            => new AssemblyArchiverService(context);

        [MethodImpl(Inline)]
        AssemblyArchiverService(IAsmContext context)
        {
            Context = context;
            Resources = Context.Compostion.FindCatalog(PartId.VData).MapValueOrElse(c => c.Resources, () => BinaryResources.Empty);
        }

        IApiComposition Resolved 
            => Context.Compostion;

        IEnumerable<PartId> ActiveAssemblies
            => Context.ActiveAssemblies();

        Option<FilePath> ReportEmissions(PartId src, AsmEmissionTokens<OpUri>[] emitted, AsmEmissionKind kind)
            => AsmEmissionReport.Create(src, emitted, kind).Save(AsmEmissionPaths.The.EmissionPath(src, kind));

        AsmEmissionTokens<OpUri>[] EmitPrimary(in OpExtractExchange exchange, IApiCatalogProvider src,  IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionTokens<OpUri>>(); 

            void OnEmission(in AsmEmissionTokens<OpUri> emission) => emissions.Add(emission);            
            
            emitter.EmitPrimary(exchange,OnEmission);

            return emissions.ToArray();
        }        

        AsmEmissionTokens<OpUri>[] EmitImm(in OpExtractExchange exchange, IApiCatalogProvider src, IAsmCatalogEmitter emitter)
        {
            var emissions = new List<AsmEmissionTokens<OpUri>>();   
            
            void OnEmission(in AsmEmissionTokens<OpUri> emission) => emissions.Add(emission);

            emitter.EmitImm(exchange,OnEmission);

            return emissions.ToArray();                
        }

        Option<FilePath> EmitLocations(IApiCatalogProvider src)
        {
            return MemberLocationReport.Create(src.PartId, src.Part).Save();
        }

        void Completed(Option<FilePath> report)
        {
            report.OnSome(p => term.inform($"Completed emission task and saved report to {p}"))
                  .OnNone(() => term.error($"Emission task failure"));
            report.Require();
        }

        void Archive(in OpExtractExchange exchange, IApiCatalogProvider src)
        {
            void OnEmission(in AsmEmissionTokens<OpUri> data)
            {

            }

            var metadata = src.Part.CreateClrIndex();            
            var emitter = AsmCatalogEmitter.Create(Context, src.Operations, OnEmission);

            var primary = EmitPrimary(exchange, src, emitter);
            if(primary.Length != 0)
                Completed(ReportEmissions(src.PartId, primary, AsmEmissionKind.Primary));
            
            var imm = EmitImm(exchange, src, emitter);
            if(imm.Length != 0)
                Completed(ReportEmissions(src.PartId, imm, AsmEmissionKind.Imm));
            
            Completed(EmitLocations(src));
        }

        public void Archive(PartId id)
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            var provider = Resolved.CatalogProvider(id);
            if(provider.IsSome())
            {
                var exchange = Context.ExtractExchange(OnCaptureEvent);
                Archive(in exchange, provider.Value);
            }
        }

        public void Execute(params string[] args)
        {             
            void OnCaptureEvent(in AsmCaptureEvent data)
            {

            }

            var exchange = Context.ExtractExchange(OnCaptureEvent);
            var providers = Resolved.CatalogProviders(ActiveAssemblies);
            
            foreach(var src in providers)
                Archive(exchange, src);

            DataResourceReport.Create(PartId.VData, Resources).Save().Require();
        }
    }
}