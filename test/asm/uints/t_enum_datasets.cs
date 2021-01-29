//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_enum_datasets : t_asm<t_enum_datasets>
    {
        public t_enum_datasets()
        {
            UnitDataDir.Clear();
        }

        FS.FilePath EnumDatasetPath<E>()
            where E : unmanaged, Enum
                => FS.path(CasePath($"{typeof(E).Name}.Metadata").Name);

        FS.FilePath EnumIdentifiers<E>()
            where E : unmanaged, Enum
                => FS.path(CasePath($"{typeof(E).Name}.Identifiers").Name);

        EnumDataset<E,T> emit<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => EnumLiteralEmitter.emit<E,T>(LiteralEmissionKind.EnumDataset, EnumDatasetPath<E>());

        public void ds_1()
        {
            emit<AsciCharCode,byte>();
            emit<BitSeq8,byte>();
            emit<Hex8Seq,byte>();
            emit<RegisterKind,uint>();
            emit<RegisterIndex,byte>();
            emit<RegisterClass,byte>();
            emit<RegisterWidth,ushort>();
            emit<OperatingMode,byte>();
            emit<AsmSigKeywordId,byte>();
            emit<AsmOpCodeKeywordId,byte>();
        }

        public void enum_dataset_convert()
        {
            var path = CasePath(FileExtensions.Csv);
            var enums = @readonly(Enums.describe<AsmSigKeywordId,byte>());
            EnumTables.emit(enums,path);
        }

    }
}