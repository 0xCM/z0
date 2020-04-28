//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Defines grid dimensions based on specification without parametrization
    /// </summary>
    public readonly struct GridIdentity : IIdentification<GridIdentity>
    {        
        public static GridIdentity Empty => default;

        public static GridIdentity Parse(string src)
        {
            var parts = text.split(src, IDI.SegSep);
            if(parts.Length == 3)
            {
                var numeric = NumericParser.create<ulong>();
                var m = numeric.Parse(parts[0]).ValueOrDefault();
                var n = numeric.Parse(parts[1]).ValueOrDefault();
                var kind = parts[2];
                if(kind.Length > 0)
                {
                    var width =  (NumericWidth)numeric.Parse(kind.TrimEnd(kind.Last())).ValueOrDefault();
                    var type = ((NumericWidth)width).ToNumericKind(NumericIndicator.Unsigned);
                    return new GridIdentity(m, n, type);
                }
            }
            return Empty;
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly ulong M;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly ulong N;

        /// <summary>
        /// The numeric cell type
        /// </summary>
        public readonly NumericKind T;

        public NumericWidth CellWidth => (NumericWidth)T.Width();

        public string Identifier => $"{M}{IDI.SegSep}{N}{IDI.SegSep}{CellWidth.FormatValue()}w";

        public static bool operator ==(GridIdentity d1, GridIdentity d2)
            => d1.Equals(d2);

        public static bool operator !=(GridIdentity d1, GridIdentity d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public static implicit operator GridIdentity((ulong m, ulong n, NumericKind t) src)
            => new GridIdentity(src.m,src.n,src.t);

        [MethodImpl(Inline)]
        public static implicit operator (ulong m, ulong n, NumericKind t)(GridIdentity src)
            => (src.M, src.N, src.T);

        [MethodImpl(Inline)]
        public GridIdentity(ulong m, ulong n, NumericKind t)
        {
            this.M = m;
            this.N = n;
            this.T = t;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => M == 0 && N == 0 && T == 0;
        }

        /// <summary>
        /// Formats the dimension in canonical form
        /// </summary>
        public string Format()
            => Identifier;

        [MethodImpl(Inline)]
        public bool Equals(GridIdentity src)
            => M == src.M 
            && N == src.N 
            && T == src.T;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(M,N);
        
        public override bool Equals(object src)
            => src is GridIdentity id && Equals(id);
    }
}