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

    public readonly struct TabularFormat<F> : ITextual
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

        public int FieldCount => Fields.Length;

        public ref readonly TabularField<F> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Fields[i];
        }        

        [MethodImpl(Inline)]
        internal TabularFormat(TabularField<F>[] fields)
        {
            Fields = fields;
            Headers = fields.Map(f => f.Name);
        }
                
        /// <summary>
        /// Formats the format specification, not the object being specified
        /// </summary>
        public string Format()
        {
            var dst = new StringBuilder();
            for(var i=0; i< Fields.Length; i++)
                dst.AppendLine(this[i].Format());
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}