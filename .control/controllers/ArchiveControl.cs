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
        IOperationCatalog Check(IOperationCatalog catalog)
        {
            if(catalog.IsEmpty)
                print(CatalogEmpty(catalog));
            else
                print(EmittingCatalog(catalog));
            return catalog;
        }

        Option<Pair<IOperationCatalog,FilePath>> Emit(AssemblyId id)
            => from catalog in FindCatalog(id)  
                let emitter = AsmServices.CatalogEmitter(catalog)      
                let descriptors = array(emitter.EmitCatalog())
                from path in AsmEmissionReport.Create(catalog, descriptors)
                select paired(catalog, path);
            
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

        void OnCatalogEmitted(Pair<IOperationCatalog,FilePath> result)
        {
            print($"Successfully created {result.A.CatalogName} emission report at {result.B}");
        }

        public override void Execute()
        {             
            print(EmittingAsmArchives());

            FindCatalog(AssemblyId.Data).OnSome(c => DataResourceReport.Create(c));

            foreach(var id in EnabledAssemblies)
                Emit(id).OnSome(OnCatalogEmitted).OnNone(() => CatalogNotFound(id));
        }
    }
}