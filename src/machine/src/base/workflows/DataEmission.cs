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

    public readonly struct DatasetField
    {
        public readonly ushort Index;

        public readonly StringRef Name;

        public readonly ushort Width;

        [MethodImpl(Inline)]
        public DatasetField(ushort index, string name, ushort width)
        {
            Index = index;
            Name = name;
            Width = width;
        }
    }
    
    public readonly struct DataEmission
    {
        public static PartId part(FilePath src)        
            => PartIdParser.single(src.FileName.Name.Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));
        
        public static ReadOnlySpan<DatasetField> fields<E>()
            where E : unmanaged, Enum
        {
            var fields = span(typeof(E).LiteralFields());
            var count = fields.Length;
            var dst = span<DatasetField>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new DatasetField((ushort)i, field.Name, (ushort)field.GetRawConstantValue());
            }
            return dst;
        }

        public static string header(ReadOnlySpan<DatasetField> fields, char delimiter = FieldDelimiter)
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

        public static void emitted<F,D>(F wf, D dk, PartId part, int count)
            where F : IWorkflow
            where D : unmanaged, Enum
                => wf.Deposit(Events.create($"{dk}_ran", $"Emitted {count} {dk} {part.Format()} records", AppMsgColor.Cyan));
    }
}