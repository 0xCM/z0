//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableRenderSpec<F> : ITextual
        where F : unmanaged
    {
        /// <summary>
        /// The field specifications
        /// </summary>
        public readonly TableColumn<F>[] Fields;

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

        public ref readonly TableColumn<F> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Fields[i];
        }

        public static implicit operator TableRenderSpec(TableRenderSpec<F> src)
            => src.Generalize();

        [MethodImpl(Inline)]
        public TableRenderSpec(TableColumn<F>[] columns)
        {
            Fields = columns;
            Headers = columns.Map(f => f.Name);
        }

        public TableRenderSpec Generalize()
        {
            var src = this;
            var count = src.FieldCount;
            var fields = sys.alloc<TableColumn>(count);
            var headers = sys.alloc<string>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref src[i];
                fields[i] = new TableColumn((ushort)x.Index, x.Name, (ushort)x.Width);
                headers[i] = x.Name;
            }
            return new TableRenderSpec(fields, headers, src.Delimiter, src.EmitHeader);
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