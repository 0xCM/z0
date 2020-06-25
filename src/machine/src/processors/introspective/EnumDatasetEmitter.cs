//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

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
                => DatasetRoot + FileName.Define($"{typeof(E).Name}.Metadata", FileExtensions.Csv);
        
        void emit<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = path<E>();
            term.print($"Emitting {typeof(E).Name} dataset to {dst}");            
            EnumDatasets.Service.emit<E,T>(dst);
        }

        
        public void Emit()
        {            
            emit<AsciCharCode,byte>();
            emit<Octet,byte>();
            emit<HexKind,byte>();
            emit<RegisterKind,uint>();
            emit<RegisterCode,byte>();
            emit<RegisterClass,byte>();
            emit<RegisterWidth,ushort>();
            emit<OperatingMode,byte>();
            emit<InstructionToken,byte>();
            emit<OpCodeTokenKind,byte>();

        }    
    }
}