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
            var emitter = context.StatsEmitter(catalog);
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

        void CatalogEmitted(IOperationCatalog catalog)
            => print($"Successfully emitted {catalog.CatalogName} catalog");


        void CatalogEmissionFailed(IOperationCatalog catalog)
            => errout($"Error occurred while emitting catalog {catalog.CatalogName}");

        public override void Execute()
        {             
            var rescat = FindCatalog(AssemblyId.Data).Require();
            rescat.SaveResourceIndex().Require();
            var assemblies = 
                (from d in Designators.Control.Designated.Designates
                where EnabledAssemblies.Contains(d.Id) && d.Catalog != null && !d.Catalog.IsEmpty
                    select (d.Id, d.DeclaringAssembly, d.Catalog)).ToArray();                                    
            
            foreach(var a in assemblies)
            {
                var context = AsmContext.New(ClrMetadataIndex.Create(a.DeclaringAssembly),  rescat.Resources, AsmFormatConfig.Default);
                AsmServices.EmitMemberLocations( a.Id,a.DeclaringAssembly).Require();

                context.EmitCatalog(a.Catalog)
                             .OnSome(_ => CatalogEmitted(a.Catalog))
                             .OnNone(() => CatalogEmissionFailed(a.Catalog));
            }
        }
    }
}