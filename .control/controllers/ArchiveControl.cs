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
        readonly IAsmContext Context;
        
        public ArchiveControl()
        {
            Context = AsmContext.New();

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
            var res = FindCatalog(AssemblyId.Data).Require().Resources;
            var rr = AsmReports.CreateResourceReport(res);
            rr.Save().Require();

            var designates = 
                from d in Designators.Control.Designated.Designates
                let active = Context.ActiveAssemblies()
                where active.Contains(d.Id) && d.Catalog != null && !d.Catalog.IsEmpty
                    select (d.Id, d.DeclaringAssembly, d.Catalog);
            
            foreach(var (id, a, cat) in designates)
            {
                var metadata = ClrMetadataIndex.Create(a);
                var context = AsmContext.New(metadata, res);
                var lr = AsmReports.CreateMemberLocationReport(id, a);
                lr.Save().Require();

                var emitter = context.CatalogEmitter(cat);
                var emitted = emitter.EmitCatalog().ToArray();
                var er = AsmReports.CreateEmissionReport(id, emitted);
                er.Save().OnSome(_ => CatalogEmitted(cat))
                         .OnNone(() => CatalogEmissionFailed(cat));

            }
        }
    }
}