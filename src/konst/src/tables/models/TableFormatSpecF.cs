//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableFormatSpec<F> : ITextual
        where F : unmanaged, Enum
    {
        /// <summary>
        /// The field specifications
        /// </summary>
        public readonly TabularField<F>[] Fields;

        /// <summary>
        /// The column header names
        /// </summary>
        public readonly string[] Headers;

        public int FieldCount
            => Fields.Length;

        public bool EmitHeader
            => true;

        public char Delimiter
            => FieldDelimiter;

        public ref readonly TabularField<F> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Fields[i];
        }

        public static implicit operator TableFormatSpec(TableFormatSpec<F> src)
            => src.Generalize();

        [MethodImpl(Inline)]
        public TableFormatSpec(TabularField<F>[] fields)
        {
            Fields = fields;
            Headers = fields.Map(f => f.Name);
        }

        public TableFormatSpec Generalize()
        {
            var src = this;
            var count = src.FieldCount;
            var fields = sys.alloc<TabularField>(count);
            var headers = sys.alloc<string>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref src[i];
                fields[i] = new TabularField(x.Name, x.Index, x.Width);
                headers[i] = x.Name;
            }
            return new TableFormatSpec(fields, headers, src.Delimiter, src.EmitHeader);
        }

        /// <summary>
        /// Formats the format specification, not the object being specified
        /// </summary>
        public string Format()
        {
            var dst = text.build();
            for(var i=0; i<FieldCount; i++)
                dst.AppendLine(this[i].Format());
            return dst.ToString();
        }

        public string FormatHeader()
        {
            var dst = text.build();
            for(var i=0; i<FieldCount; i++)
            {
                ref readonly var field = ref this[i];
                //dst.Append(Space);
                dst.Append(Delimiter);
                dst.Append(Space);
                dst.Append(field.Name.PadRight(field.Width));
            }

            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}