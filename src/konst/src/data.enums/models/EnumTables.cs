//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = EnumDatasetField;

    public readonly struct EnumTables
    {
        public static void emit<E,T>(ReadOnlySpan<EnumLiteralInfo<E,T>> src, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(header<F>());
            var buffer = Buffers.text();

            var dataset = Enums.dataset<E,T>();
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(format(src[i],buffer));
        }

        public static string header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = Enums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        public static string header(Type src, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            var labels = Enums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        public static string format<E,T>(in EnumLiteralInfo<E,T> src, ITextBuffer dst, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            dst.Delimit(F.Token, src.Id);
            dst.Delimit(F.Index, src.Position);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);
            return dst.Emit();
        }
    }
}