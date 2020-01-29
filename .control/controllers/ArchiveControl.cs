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
    using static AsmServiceMessages;
    
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


        public override void Execute()
        {             
            var designates = 
                from d in Designators.Control.Designated.Designates
                let active = Context.ActiveAssemblies()
                where active.Contains(d.Id) && d.Catalog != null && !d.Catalog.IsEmpty
                    select (d.Id, d.DeclaringAssembly, d.Catalog);
            
            var res = FindCatalog(AssemblyId.Data).Require().Resources;
            var rr = AsmReports.CreateResourceReport(res);
            rr.Save().Require();

            foreach(var (id, a, cat) in designates)
                AsmContext.New(ClrMetadataIndex.Create(a), res).EmitCatalog(cat);
        }
    }
}