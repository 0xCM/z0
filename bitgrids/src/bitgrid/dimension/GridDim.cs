//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// Defines grid dimensions based on specification without parametrization
    /// </summary>
    public readonly struct GridDim 
    {        
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly int RowCount;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly int ColCount;

        public static GridDim Empty => default;

        public static GridDim Parse(string s)
        {
            var parts = s.Split('x');
            if(parts.Length == 2)
            {
                if(Numeric.parse(parts[0], out int m))
                if(Numeric.parse(parts[1], out int n))
                    return (m,n);
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
            this.RowCount = rows;
            this.ColCount = cols;
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
    }
}