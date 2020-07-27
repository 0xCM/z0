//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    partial struct EmissionWorkflow
    {
        public readonly struct EmitEnumData : IWorkflowWorker<EmitEnumData>
        {
            readonly IAppContext Context;

            public EmitEnumData(IAppContext context)
                => Context = context;
            
            public static EmitEnumData Service(IAppContext context)
                => new EmitEnumData(context);

            FolderPath DatasetRoot 
                => Context.AppPaths.AppDataRoot + FolderName.Define("enums");
            
            FilePath path<E>() 
                where E : unmanaged, Enum
                    => DatasetRoot + FileName.Define($"{typeof(E).Name}", FileExtensions.Csv);
            
            FilePath path(Type @enum) 
                    => DatasetRoot + FileName.Define($"{@enum.Name}", FileExtensions.Csv);

            FolderPath dir(PartId part)
                => DatasetRoot + FolderName.Define(part.Format());
            FilePath path(PartId part, Type @enum) 
                    => dir(part) + FileName.Define($"{@enum.Name}", FileExtensions.Csv);

            // void emit(PartId part, Type[] enums)
            // {
            //     dir(part).Clear();

            //     foreach(var e in enums)
            //     {
            //         var dst = path(part, e);
            //         if(e.Fields().Length != 0)
            //         {
            //             term.print($"Emitting {e.Name} dataset to {dst}");            
            //             EnumDatasets.Service.emit(e, dst);                
            //         }
            //     }
            // }

            public void Emit()
            {            
                DatasetRoot.Clear();
                
                var src = KnownParts.Service.Known;
                var parts = from part in  KnownParts.Service.Known
                            let enums = part.Owner.Enums()
                            orderby part.Id
                            select (part.Id, enums);
                    
                // foreach(var part in parts)
                // {
                //     emit(part.Id, part.enums);
                // }                                                        
            }    
        }

    }
}