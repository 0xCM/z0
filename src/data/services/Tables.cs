//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using F = FarCallCountsField;

    using Asm;
    
    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Tables
    {

        [MethodImpl(Inline), Op]
        public static void render(in FarCallCounts src, StringBuilder dst)
        {            
            var formatter = Tables.formatter<F>(dst);
            formatter.Delimit(F.TargetsFar, src.TargetsFar);
            formatter.Delimit(F.HostedReceivers, src.HostedReceivers);
            formatter.Delimit(F.UnhostedReceivers, src.UnhostedReceivers);        
        }                
        public static EnumNames<Mnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<Mnemonic>();
        }

        public static PartId part(FilePath src)        
            => PartIdParser.single(src.FileName.Name.Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));

        [Op]
        public static ReadOnlySpan<TableColumn> fields<E>()
            where E : unmanaged, Enum
        {
            var fields = span(typeof(E).LiteralFields());
            var count = fields.Length;
            var dst = span<TableColumn>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new TableColumn((ushort)i, field.Name, (ushort)field.GetRawConstantValue());
            }
            return dst;
        }

        public static string header(ReadOnlySpan<TableColumn> fields, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                if(i != 0)
                {
                    dst.Append(Space);
                    dst.Append(delimiter);
                    dst.Append(Space);
                }
                
                ref readonly var field = ref skip(fields,i);
                var name = field.Name.Format();            
                if(i != count - 1)
                    dst.Append(name.PadRight(field.Width));
                else
                    dst.Append(name);
            }
            return dst.ToString();
        }

        public static string header<E>(char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
                => header(fields<E>(), delimiter);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>()
            where F : unmanaged, Enum
            => new TableFormatter<F>(new StringBuilder(), FieldDelimiter);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(char delimiter)
            where F : unmanaged, Enum
            => new TableFormatter<F>(new StringBuilder(), delimiter);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(StringBuilder dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(dst, delimiter);    
    }
}