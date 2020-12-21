//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct RowFormat
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines a <see cref='RowFormatSpec'/>
        /// </summary>
        /// <param name="header">The row header</param>
        /// <param name="cells">The cell specs</param>
        [MethodImpl(Inline), Op]
        public static RowFormatSpec rowspec(RowHeader header, CellFormatSpec[] cells)
            => new RowFormatSpec(header, cells);

        /// <summary>
        /// Defines a <see cref='CellFormatSpec'/>
        /// </summary>
        /// <param name="pattern">The cell format pattern</param>
        /// <param name="lpad"></param>
        /// <param name="rpad"></param>
        [MethodImpl(Inline), Op]
        public static CellFormatSpec cellspec(string pattern, ushort lpad, ushort rpad = 0)
            => new CellFormatSpec(pattern, lpad, rpad);

        /// <summary>
        /// Formats a <see cref='RowHeader'/>
        /// </summary>
        /// <param name="src">The source header</param>
        public static string format(RowHeader src)
        {
            var dst = text.build();
            for(var i=0; i<src.Count; i++)
                dst.Append(text.format(RP.SlottedSpacePipe, src[i].Format()));
            return dst.ToString();
        }

        [Op]
        public static string format(dynamic src, in CellFormatSpec spec)
        {
            string data = spec.Pattern.Format(src);
            if(spec.LeftPad != 0)
                data = data.PadLeft(spec.LeftPad);
            if(spec.RightPad != 0)
                data = data.PadRight(spec.RightPad);
            return data;
        }

        [Op, Closures(Closure)]
        public static void render<T>(DynamicRow<T> src, in RowFormatSpec spec, ITextBuffer dst)
            where T : struct
        {
            var count = spec.CellCount;
            ref readonly var cf = ref spec.Cells.First;
            ref readonly var cd = ref first(src.View);
            for(var i=0; i<count; i++)
                dst.Append(format(skip(cd,i), skip(cf,i)));
        }
    }
}