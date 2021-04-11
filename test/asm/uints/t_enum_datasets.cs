//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class t_enum_datasets : t_asm<t_enum_datasets>
    {
        public t_enum_datasets()
        {

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
            emit<RegKind,uint>();
            emit<RegIndex,byte>();
            emit<RegClass,byte>();
            emit<RegWidth,ushort>();
        }

    }
}