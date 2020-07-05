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

        public string format<E,T>(in EnumInfo<E,T> src, char delimiter = Chars.Pipe)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Token);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);

            return dst.ToString();
        }
        
        public void emit<E,T>(ReadOnlySpan<EnumInfo<E,T>> src, FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());
            
            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<src.Length; i++)
            {
                writer.WriteLine(format(src[i]));
            }
        }
        
        FilePath EnumDatasetPath<E>() 
            where E : unmanaged, Enum
                => CasePath($"{typeof(E).Name}.Metadata");

        FilePath EnumIdentifiers<E>() 
            where E : unmanaged, Enum
                => CasePath($"{typeof(E).Name}.Identifiers");
        

        void emit<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            EnumDatasets.Service.emit<E,T>(EnumDatasetPath<E>());
        }
        
        public void ds_1()
        {            
            emit<AsciCharCode,byte>();
            emit<BitSeq8,byte>();
            emit<Hex8Kind,byte>();
            emit<RegisterKind,uint>();
            emit<RegisterCode,byte>();
            emit<RegisterClass,byte>();
            emit<RegisterWidth,ushort>();
            emit<OperatingMode,byte>();
            emit<InstructionTokenKind,byte>();
            emit<OpCodeTokenKind,byte>();
        }
        
        public void enum_dataset_convert()
        {
            var path = CasePath(FileExtensions.Csv);
            var enums = @readonly(Enums.describe<InstructionTokenKind,byte>());
            emit(enums,path);
        }
    }
}