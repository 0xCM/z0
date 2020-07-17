//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
 

    using F = EnumDatasetEntryField;

    public enum EnumDatasetEntryField : uint
    {
        Token = 0 | 16u << 16,

        Index = 1 | 16u << 16,

        Name = 2 | 24u << 16,

        Scalar = 3 | 10 << 16
    }

    public readonly struct EnumDatasets
    {
        public static EnumDatasets Service => default;

        public string header<F>(char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = Enums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        public string format<E,T>(in EnumDatasetEntry<E,T> src, char delimiter = Chars.Pipe)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Token);
            dst.Delimit(F.Index, src.Position);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);

            return dst.ToString();
        }

        public string format(in EnumDatasetEntry src, char delimiter = Chars.Pipe)
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Id);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);

            return dst.ToString();
        }

        // public void emit(Type @enum, FilePath dst)
        // {
        //     using var writer = dst.Writer();
        //     writer.WriteLine(header<F>());
            
        //     var dataset = Enums.dataset(@enum);
        //     for(var i=0; i<dataset.EntryCount; i++)
        //         writer.WriteLine(format(dataset[i]));
        // }        

        public void emit<E,T>(FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());
            
            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<dataset.EntryCount; i++)
                writer.WriteLine(format(dataset[i]));
        }        
    }
}