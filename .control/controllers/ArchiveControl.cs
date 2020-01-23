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
    using System.IO;

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

        void DescribeResources(IOperationCatalog catalog)
        {            
            var dst = Paths.AsmDataDir(FolderName.Define(catalog.CatalogName)) + FileName.Define("data", "csv");
            dst.FolderPath.CreateIfMissing();
            var delimter = spaced(pipe());
            var header = concat(
                "Offset".PadRight(8), delimter,
                "Location".PadRight(16), delimter,  
                "Length".PadRight(10), delimter, 
                "Id") ;

            var start = 0ul;
            using var writer = new StreamWriter(dst.Name, false);  
            writer.WriteLine(header);         
            foreach(var r in catalog.Resources.OrderBy(x => x.Location))
            {
                if(start == 0)
                    start = r.Location;
                    
                var offset = r.Location - start;

                
                var description = concat(
                        offset.FormatAsmHex(4).PadRight(8), delimter,
                        r.Location.FormatAsmHex().PadRight(16), delimter, 
                        r.Length.FormatAsmHex(4).PadRight(10), delimter, 
                        r.Id);
                writer.WriteLine(description);
            }
        }

        IOperationCatalog Emitted(IOperationCatalog catalog, AsmDescriptor[] emissions)
        {
            if(emissions.Length == 0)
                return catalog;
            
            Array.Sort(emissions);

            var logext = "csv";

            var dst = Paths.AsmDataDir(FolderName.Define("logs")) + FileName.Define(catalog.CatalogName, logext);
            var padoffset = 8;
            var padbytes = 10;
            dst.FolderPath.CreateIfMissing();
            var delimter = spaced(pipe());
            using var writer = new StreamWriter(dst.Name, false);            
        
            var root = emissions[0].Origin.Start;
            var current = emissions[0];
            var prior = emissions[0];
            for(var i=0; i<emissions.Length; i++)
            {                
                var origin = current.Origin;
                var description = (i != 0 ? current.Origin.Start - root : 0ul).FormatAsmHex(padoffset);
                description += delimter;
                description += $"{current.Origin.Start.FormatAsmHex()} : {current.Origin.End.FormatAsmHex()}";
                description += delimter;
                description += $"{origin.Length} bytes".PadRight(padbytes);
                description += delimter;
                description += current.Uri.Format();
                writer.WriteLine(description);

                prior = current;
                if(i != emissions.Length - 1)
                   current = emissions[i + 1]; 
            }

            return catalog;
        }

        Option<IOperationCatalog> Emit(AssemblyId id)
            => from catalog in FindCatalog(id)        
                let descriptors = Check(catalog).Emit()
                select Emitted(catalog,descriptors.ToArray());
            
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

        void OnCatalogEmitted(IOperationCatalog catalog)
        {

        }

        public override void Execute()
        {             
            print(EmittingAsmArchives());

            FindCatalog(AssemblyId.Data).OnSome(c => DescribeResources(c));

            foreach(var id in EnabledAssemblies)
                Emit(id).OnSome(OnCatalogEmitted).OnNone(() => CatalogNotFound(id));
        }
    }
}