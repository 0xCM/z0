//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using F = EnumDatasetField;

    public readonly struct EnumLiteralEmitter : IEnumLiteralEmitter
    {
        public static IEnumLiteralEmitter Service => default(EnumLiteralEmitter);

        public static void emit<E,T>(LiteralEmissionKind kind, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            switch(kind)
            {
                case LiteralEmissionKind.EnumDataset:
                    EmitDataset<E,T>(dst);
                break;
                case LiteralEmissionKind.EnumInfoset:
                    EmitInfoset<E,T>(dst);
                break;
                default:
                    throw no<LiteralEmissionKind>();
            }
        }

        static void EmitInfoset<E,T>(FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
                => emit(@readonly(Enums.describe<E,T>()),dst);

        static void EmitDataset<E,T>(FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());

            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<dataset.EntryCount; i++)
                writer.WriteLine(Enums.format(dataset[i]));
        }

        static void emit<E,T>(ReadOnlySpan<EnumLiteralInfo<E,T>> src, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());

            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(Enums.format(src[i]));
        }

        static string header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = Enums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        void IEnumLiteralEmitter.Emit<E,T>(LiteralEmissionKind kind, FS.FilePath dst)
            => emit<E,T>(kind,dst);
    }
}