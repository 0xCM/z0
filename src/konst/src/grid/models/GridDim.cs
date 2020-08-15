//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines grid dimensions based on specification without parametrization
    /// </summary>
    public readonly struct GridDim : IGridDim
    {        
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly int RowCount;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly int ColCount;

        public static GridDim Parse(string s)
        {
            var parts = s.Split('x');
            var parser = Parsers.numeric<int>();
            if(parts.Length == 2)
            {
                var result = from m in parser.Parse(parts[0])
                             from n in parser.Parse(parts[1])
                             select new GridDim(m,n);
                return result.Succeeded ? result.Value : Empty;
            }
            return Empty;
        }

        public static bool operator ==(GridDim d1, GridDim d2)
            => d1.Equals(d2);

        public static bool operator !=(GridDim d1, GridDim d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public static implicit operator GridDim((int rows, int cols) src)
            => new GridDim(src.rows,src.cols);

        [MethodImpl(Inline)]
        public static implicit operator (int rows, int cols)(GridDim src)
            => (src.RowCount, src.ColCount);

        [MethodImpl(Inline)]
        public GridDim(int rows, int cols)
        {
            RowCount = rows;
            ColCount = cols;
        }

        /// <summary>
        /// Formats the dimension in canonical form
        /// </summary>
        public string Format()
            => $"{RowCount}x{ColCount}";

        [MethodImpl(Inline)]
        public void Deconstruct(out int rows, out int cols)
        {
            rows = RowCount;
            cols = ColCount;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridDim src)
            => src.RowCount == RowCount && src.ColCount == ColCount;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(RowCount,ColCount);
        
        public override bool Equals(object obj)
            => obj is GridDim d && Equals(d);

        public static GridDim Empty 
            => default;

        int IGridDim.RowCount 
        {
            [MethodImpl(Inline)]
            get => RowCount;
        }

        int IGridDim.ColCount 
        {
            [MethodImpl(Inline)]
            get => ColCount;
        }
    }
}