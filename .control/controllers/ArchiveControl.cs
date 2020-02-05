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
                        
        public override void Execute()
        {             
            var designates = 
                from d in Designators.Control.Designated.Designates
                let active = Context.ActiveAssemblies()
                where active.Contains(d.Id) && d.Catalog != null && !d.Catalog.IsEmpty
                    select (d.Id, d.DeclaringAssembly, d.Catalog);
            
            var res = FindCatalog(AssemblyId.Data).Require().Resources;
            AsmReports.CreateResourceReport(res).Save().Require();

            foreach(var (id, a, cat) in designates)
            {             
                
                var metadata = ClrMetadataIndex.Create(a);
                var context = AsmContext.New(metadata, res);
                var emitter = context.CatalogEmitter(cat);      
                
                var primary = array(emitter.EmitPrimary());  
                if(primary.Length != 0)    
                    AsmReports.CreateEmissionReport(id, primary).Save().Require();

                var imm = array(emitter.EmitImm());
                if(imm.Length != 0)                
                    AsmReports.CreateEmissionReport(id, imm, OpIdentity.Imm).Save().Require();
                
                AsmReports.CreateMemberLocationReport(id, a).Save().Require();                
            }            
        }
    }
}