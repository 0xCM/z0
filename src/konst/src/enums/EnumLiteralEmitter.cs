//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    using F = EnumDatasetField;

    public readonly struct EnumLiteralEmitter : IEnumLiteralEmitter
    {
        public static IEnumLiteralEmitter Service => default(EnumLiteralEmitter);

        public static EnumDataset<E,T> emit<E,T>(LiteralEmissionKind kind, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            switch(kind)
            {
                case LiteralEmissionKind.EnumDataset:
                    return EmitDataset<E,T>(dst);
                case LiteralEmissionKind.EnumInfoset:
                    return EmitInfoset<E,T>(dst);
                default:
                    throw no<LiteralEmissionKind>();
            }
        }

        static EnumDataset<E,T> EmitInfoset<E,T>(FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
                => emit(@readonly(Enums.describe<E,T>()),dst);

        static EnumDataset<E,T> EmitDataset<E,T>(FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());

            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<dataset.EntryCount; i++)
                writer.WriteLine(Enums.format(dataset[i]));
            return dataset;
        }

        static EnumDataset<E,T> emit<E,T>(ReadOnlySpan<EnumLiteralInfo<E,T>> src, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());

            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(Enums.format(src[i]));
            return dataset;
        }

        static string header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = Enums.literals<F>();
            var count = labels.Length;
            for(var i=0; i<count; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        void IEnumLiteralEmitter.Emit<E,T>(LiteralEmissionKind kind, FS.FilePath dst)
            => emit<E,T>(kind,dst);
    }
}