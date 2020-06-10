//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Seed;
    using static Memories;
 
    using Z0.Asm.Data;

    using F = EnumDatasetEntryField;
    
    public enum EnumDatasetEntryField : uint
    {
        Token = 0 | 16u << 16,

        Index = 1 | 16u << 16,

        Identifier = 2 | 24u << 16,

        NumericValue = 3 | 10 << 16
    }

    public class t_enum_datasets : t_asmd<t_enum_datasets>
    {
        
        public t_enum_datasets()
        {
            UnitRoot.Clear();   

        }
        static string header<F>(char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = Enums.valarray<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        static string format<E,T>(in EnumDatasetEntry<E,T> src, char delimiter = Chars.Pipe)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Token);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Identifier, src.Name);
            dst.Delimit(F.NumericValue, src.Scalar);

            return dst.ToString();
        }
        
        static void emit<E,T>(FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());
            
            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<dataset.EntryCount; i++)
                writer.WriteLine(format(dataset[i]));
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
            emit<E,T>(EnumDatasetPath<E>());
        }
        
        public void ds_1()
        {
            
            emit<AsciCharCode,byte>();
            emit<Octet,byte>();
            emit<HexKind,byte>();
            emit<RegisterKind,uint>();
            emit<RegisterCode32,byte>();
            emit<RegisterClass,byte>();
            emit<RegisterWidth,ushort>();
            emit<OperatingMode,byte>();
            emit<InstructionToken,byte>();
            emit<OpCodeToken,byte>();
        }

        public void ds_2()
        {
            var path = EnumIdentifiers<InstructionToken>();
            using var dst = path.Writer();

            var dataset = Enums.dataset<InstructionToken,byte>();
            var count = dataset.EntryCount;
            for(var i=0; i<count; i++)
            {
                var entry = dataset[i];
                var index = entry.Index;
                var identifier = entry.Name;
                var value = entry.Scalar;

                
                var e = Symbolic.@enum(entry.Index,entry.Name, entry.Literal, entry.Scalar);

                
            }



                        

        }

    }
}