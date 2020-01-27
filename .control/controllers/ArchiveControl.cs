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
    using System.Reflection;

    using static zfunc;
    using static ControlMessages;
    
    class ArchiveControl : Controller<ArchiveControl>
    {                
        public ArchiveControl()
        {
            

        }

        Option<AsmStats> DispatchStatsWorker(IAsmContext context, IOperationCatalog catalog)
        {
            var emitter = AsmServices.StatsEmitter(context, catalog);
            return emitter();            
        }
                        
        static IEnumerable<AssemblyId> EnabledAssemblies
        {
            get
            {
                var settings = AppSettings.Load(typeof(ArchiveControl).Assembly.GetSimpleName()).Pairs;
                foreach(var (key,value) in settings)
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

        void CatalogEmitted(string id, FilePath report)
            => print($"Successfully emitted {id} catalog and wrote emission report to {report}");


        void CatalogEmissionFailed(string id)
            => errout($"Error occurred while emitting catalog {id}");

        DataResourceIndex CreateResourceIndex()
            => FindCatalog(AssemblyId.Data).MapRequired(c =>  DataResourceReport.Create(c.Resources,"data"));

        Option<FilePath> Emit(IAsmContext context, IOperationCatalog catalog)
        {
            var emitted = AsmServices.CatalogEmitter(context,catalog).EmitCatalog();
            return AsmEmissionReport.Create(catalog, emitted.ToArray());
        }

        public override void Execute()
        {             
            var resources = CreateResourceIndex();
            var assemblies = 
                (from d in Designators.Control.Designated.Designates
                where EnabledAssemblies.Contains(d.Id) && d.Catalog != null && !d.Catalog.IsEmpty
                    select (d.Id, d.DeclaringAssembly, d.Catalog)).ToArray();                                    
            
            foreach(var a in assemblies)
            {
                var clrindex = AsmServices.IndexAssembly(a.DeclaringAssembly);
                var catalog = a.Catalog;
                var context =  AsmServices.Context(clrindex, resources, AsmFormatConfig.Default);
                Emit(context, a.Catalog).OnSome(path => CatalogEmitted(catalog.CatalogName, path))
                             .OnNone(() => CatalogEmissionFailed(catalog.CatalogName));
            }
        }
    }
}