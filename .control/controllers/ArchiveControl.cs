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
    using static ControlMessages;
    
    class ArchiveControl : Controller<ArchiveControl>
    {                
        IEnumerable<AsmEmissionToken> EmitArtifacts(IOperationCatalog catalog)
            => AsmServices.CatalogEmitter(catalog).EmitCatalog();

        Option<FilePath> CreateEmissionReport(IOperationCatalog catalog, IEnumerable<AsmEmissionToken> emitted)
            => AsmEmissionReport.Create(catalog, emitted.ToArray());

        Option<FilePath> Emit(IOperationCatalog catalog)
            => CreateEmissionReport(catalog,EmitArtifacts(catalog));

        Option<FilePath> Emit(AssemblyId id)
            => from catalog in FindCatalog(id)  
                from path in Emit(catalog)
                select path;
            
        AppMsg Tell(AppMsg msg)            
        {
            print(msg);
            return msg;
        }
        IAppSettings Settings
            => AppSettings.Load(GetType().Assembly.GetSimpleName());

        IEnumerable<AssemblyId> EnabledAssemblies
        {
            get
            {
                foreach(var (key,value) in Settings.Pairs)
                {
                    var index = key.Split(colon());            
                    if(index.Length == 2 && bit.Parse(index[1]))
                    {
                        var id = Enums.parse<AssemblyId>(value);
                        if(id != AssemblyId.None)
                            yield return id;                        
                    }
                }
            }
        }

        void OnCatalogEmitted(AssemblyId id, FilePath report)
            => print($"Successfully emitted {id} catalog and wrote emission report to {report}");

        void NoJoy()
            => errout($"Something went terribly wrong and the idiot that wrote me didn't bother with saying why");

        Option<AsmStats> DispatchStatsWorker(IOperationCatalog catalog)
        {
            var emitter = AsmServices.StatsEmitter(catalog);
            return emitter();            
        }

        Option<FilePath> DispatchEmitter(AssemblyId id, IOperationCatalog catalog)
            => Emit(catalog).OnSome(report => OnCatalogEmitted(id,report));

        void DispatchEmitters()
        {
            foreach(var id in EnabledAssemblies)            
            {
                var q = from c in FindCatalog(id).OnNone(() => CatalogNotFound(id))
                        from p in DispatchEmitter(id,c)
                        select p;

                q.OnNone(() => NoJoy());
            }
        }

        void DispatchStatsWorkers()
        {
            foreach(var id in EnabledAssemblies)            
            {                            
                var q = from c in FindCatalog(id).OnNone(() => CatalogNotFound(id))
                        let start = Tell(CollectingStats(c))
                        from stats in DispatchStatsWorker(c)
                        let end = Tell(CollectedStats(c,stats))
                        select stats;

                q.OnNone(() => NoJoy());
            }
        }

        void CreateResourceReports()
        {
            FindCatalog(AssemblyId.Data).OnSome(c => DataResourceReport.Create(c));
        }
        public override void Execute()
        {             
            print(DispatchingCatalogWorkers());
            
            CreateResourceReports();
            DispatchEmitters();
            //DispatchStatsWorkers();                
        }
    }
}