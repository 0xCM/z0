//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using api = StringGrids;

    public class StringGrid
    {
        public static StringGrid create(ushort rows, ushort cols)
            => new StringGrid(rows,cols);

        internal readonly string[,] Data;

        public GridDim<ushort> Dim {get;}

        StringGrid(ushort rows, ushort cols)
        {
            Data = new string[rows,cols];
            Dim = (rows,cols);
        }

        public ushort RowCount
        {
            [MethodImpl(Inline)]
            get => Dim.RowCount;
        }

        public ushort ColCount
        {
            [MethodImpl(Inline)]
            get => Dim.ColCount;
        }

        public ref string this[ushort row, ushort col]
        {
            [MethodImpl(Inline)]
            get => ref Data[row,col];
        }

        [MethodImpl(Inline)]
        public void SetRow(ushort row, ReadOnlySpan<string> cols)
            => api.row(this, row, cols);

        public string Format()
        {
            var dst = TextTools.buffer();
            for(ushort row=0; row<RowCount; row++)
            {
                dst.AppendFormat("row[{0}]=", row);
                dst.Append("{");
                for(ushort col=0; col<ColCount; col++)
                {
                    dst.AppendFormat("'{0}'", this[row,col]);
                    if(col < ColCount - 1)
                        dst.Append(", ");
                }
                dst.Append("}");
                if(row != RowCount - 1)
                    dst.AppendLine();
            }
            return dst.Emit();
        }

        public override string ToString()
            => Format();

    }
}