//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using Z0.Asm.Data;

    using static Root;

    using F = EnumDatasetEntryField;

    public readonly struct EnumDatasetEmitter
    {
        readonly IAppContext Context;

        public EnumDatasetEmitter(IAppContext context)
        {
            Context = context;
        }
        
        public static EnumDatasetEmitter Service(IAppContext context)
            => new EnumDatasetEmitter(context);

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

        void emit<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = path<E>();
            term.print($"Emitting {typeof(E).Name} dataset to {dst}");            
            EnumDatasets.Service.emit<E,T>(dst);
        }


        void emit(PartId part, Type[] enums)
        {
            dir(part).Clear();

            foreach(var e in enums)
            {
                var dst = path(part, e);
                if(e.Fields().Length != 0)
                {
                    term.print($"Emitting {e.Name} dataset to {dst}");            
                    EnumDatasets.Service.emit(e, dst);                
                }
            }
        }

        public void Emit()
        {            
            DatasetRoot.Clear();
            
            var src = KnownParts.Service.Known;
            var parts = from part in  KnownParts.Service.Known
                        let enums = part.Owner.Enums()
                        orderby part.Id
                        select (part.Id, enums);
                
            foreach(var part in parts)
            {
                emit(part.Id, part.enums);
            }


            
            
                                            
                      

            //emit(typeof(RegisterKind));

            // emit<AsciCharCode,byte>();
            // emit<Octet,byte>();
            // emit<HexKind,byte>();
            //emit<RegisterKind,uint>();
            // emit<RegisterCode,byte>();
            // emit<RegisterClass,byte>();
            // emit<RegisterWidth,ushort>();
            // emit<OperatingMode,byte>();
            // emit<InstructionToken,byte>();
            // emit<OpCodeTokenKind,byte>();

        }    
    }
}