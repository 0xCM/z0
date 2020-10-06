//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        public static TableRenderSpec<F> renderspec<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var literals = @readonly(index<F>().Literals);
            var count = literals.Length;
            var headBuffer = sys.alloc<string>(count);
            var fieldBuffer = sys.alloc<TableColumn<F>>(count);
            var fields = span(fieldBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                seek(fields,i) = new TableColumn<F>(literal, literal.ToString(), (int)i, (short)(uint32(literal) >> WidthOffset));
            }

            return new TableRenderSpec<F>(fieldBuffer);
        }
    }
}