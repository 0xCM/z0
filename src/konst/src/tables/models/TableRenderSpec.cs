//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TableRenderSpec : ITextual
    {
        /// <summary>
        /// The field specifications
        /// </summary>
        public readonly TableColumn[] Fields;

        /// <summary>
        /// The column header names
        /// </summary>
        public readonly string[] Headers;

        /// <summary>
        /// The default field delimiter
        /// </summary>
        public readonly char Delimiter;

        /// <summary>
        /// Whether to produce a header when formatting a collection
        /// </summary>
        public readonly bool EmitHeader;

        /// <summary>
        /// The number of fields accounted for
        /// </summary>
        public readonly int FieldCount;

        [MethodImpl(Inline)]
        internal TableRenderSpec(TableColumn[] fields, string[] headers, char delimiter = Chars.Pipe, bool header = true)
        {
            Fields = fields;
            Headers = headers;
            Delimiter = delimiter;
            EmitHeader = header;
            FieldCount = fields.Length;
        }

        public ref readonly TableColumn this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Fields[i];
        }

        /// <summary>
        /// Formats the format specification, not the object being specified
        /// </summary>
        public string Format()
        {
            var dst = text.build();
            for(var i=0; i< FieldCount; i++)
                dst.AppendLine(this[i].Format());
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}