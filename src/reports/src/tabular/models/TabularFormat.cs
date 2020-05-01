//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Seed;

    public readonly struct TabularFormat : ITextual
    {    
        /// <summary>
        /// The field specifications
        /// </summary>
        public readonly TabularField[] Fields;

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

        [MethodImpl(Inline)]
        internal TabularFormat(TabularField[] fields, string[] headers, char delimiter = Chars.Pipe, bool header = true)
        {
            Fields = fields;
            Headers = headers;
            Delimiter = delimiter;
            EmitHeader = header;
        }

        public int FieldCount => Fields.Length;
                
        public ref readonly TabularField this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Fields[i];
        }        

        public string Format()
        {
            var dst = new StringBuilder();
            for(var i=0; i< Fields.Length; i++)
                dst.AppendLine(this[i].Format());
            return dst.ToString();
        }

        public TabularFormat WithDelimiter(char delimiter)
            => new TabularFormat(Fields, Headers, delimiter, EmitHeader);

        public override string ToString()
            => Format();
    }
}