//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct Table
    {
        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        public static TableRenderSpec<F> renderspec<F>(char delimiter = FieldDelimiter)
            where F : unmanaged
        {
            var literals = @readonly(Clr.literalIndex<F>().Literals);
            var count = literals.Length;
            var headBuffer = sys.alloc<string>(count);
            var fieldBuffer = sys.alloc<TableColumn<F>>(count);
            var fields = span(fieldBuffer);

            for(ushort i=0; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                seek(fields,i) = new TableColumn<F>(literal, literal.ToString(), i, (ushort)(uint32(literal) >> WidthOffset));
            }

            return new TableRenderSpec<F>(fieldBuffer);
        }
    }
}