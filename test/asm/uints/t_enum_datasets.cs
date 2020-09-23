//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using F = EnumDatasetField;

    public class t_enum_datasets : t_asm<t_enum_datasets>
    {
        public t_enum_datasets()
        {
            UnitDataDir.Clear();
        }

        public string header<F>(char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = Enums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        public string format<E,T>(in EnumLiteralInfo<E,T> src, char delimiter = Chars.Pipe)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Id);
            dst.Delimit(F.Index, src.Position);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);

            return dst.ToString();
        }

        FS.FilePath EnumDatasetPath<E>()
            where E : unmanaged, Enum
                => FS.path(CasePath($"{typeof(E).Name}.Metadata").Name);

        FS.FilePath EnumIdentifiers<E>()
            where E : unmanaged, Enum
                => FS.path(CasePath($"{typeof(E).Name}.Identifiers").Name);

        void emit<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            //EnumDatasets.Service.emit<E,T>(EnumDatasetPath<E>());
            EnumLiteralEmitter.emit<E,T>(LiteralEmissionKind.EnumDataset, EnumDatasetPath<E>());
        }

        public void ds_1()
        {
            emit<AsciCharCode,byte>();
            emit<BitSeq8,byte>();
            emit<Hex8Seq,byte>();
            emit<RegisterKind,uint>();
            emit<RegisterCode,byte>();
            emit<RegisterClass,byte>();
            emit<RegisterWidth,ushort>();
            emit<AsmOperatingMode,byte>();
            emit<AsmTokenKind,byte>();
            emit<AsmOpCodeTokenKind,byte>();
        }

        public void enum_dataset_convert()
        {
            var path = FS.path(CasePath(FileExtensions.Csv).Name);
            var enums = @readonly(Enums.describe<AsmTokenKind,byte>());
            emit(enums,path);
        }

        public void enum_dataset_convert(FS.FilePath dst)
        {
            var enums = @readonly(Enums.describe<AsmTokenKind,byte>());
            emit(enums,dst);
        }


        public void emit<E,T>(ReadOnlySpan<EnumLiteralInfo<E,T>> src, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());

            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(format(src[i]));
        }
    }
}