//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines identity for a pair NxT or MxNxT where M and N are natural types and T is numeric
    /// </summary>
    public readonly struct NatIdentity : IIdentification<NatIdentity>
    {
        public static NatIdentity Empty => default;

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly ulong? M;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly ulong N;

        /// <summary>
        /// The numeric cell type
        /// </summary>
        public readonly NumericKind T;

        static NumericKind ParseNumericKind(string kind)
        {
            var numeric = Parsers.numeric<ulong>();
            var indicator = (NumericIndicator)kind.Last();
            var w =  (NumericWidth)numeric.Parse(kind.TrimEnd(kind.Last())).ValueOrDefault();
            return ((NumericWidth)w).ToNumericKind(indicator);
        }

        public static NatIdentity Parse(string src)
        {
            var numeric = Parsers.numeric<ulong>();
            var parts = text.split(src, IDI.SegSep);
            if(parts.Length == 3)
            {
                var m = numeric.Parse(parts[0]).ValueOrDefault();
                var n = numeric.Parse(parts[1]).ValueOrDefault();
                var kind = parts[2];
                if(kind.Length > 0)
                {
                    var nk = ParseNumericKind(kind);
                    return new NatIdentity(m, n, nk);
                }
            }
            else if(parts.Length == 2)
            {
                var n = numeric.Parse(parts[0]).ValueOrDefault();
                var kind = parts[1];
                if(kind.Length > 0)
                {
                    var nk = ParseNumericKind(kind);
                    return new NatIdentity(null, n, nk);
                }

            }
            return Empty;
        }

        public Option<Type> MType => M.TryMap(m => NativeNaturals.FindType(m)).Value;

        public Type NType => NativeNaturals.FindType(N).Require();

        public NumericWidth NumericWidth => (NumericWidth)T.Width();

        public string Identifier
            => M != null
               ? $"{M}{IDI.SegSep}{N}{IDI.SegSep}{T.Format()}"
               : $"{N}{IDI.SegSep}{T.Format()}";

        public static bool operator ==(NatIdentity d1, NatIdentity d2)
            => d1.Equals(d2);

        public static bool operator !=(NatIdentity d1, NatIdentity d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public static implicit operator NatIdentity((ulong? m, ulong n, NumericKind t) src)
            => new NatIdentity(src.m,src.n,src.t);

        [MethodImpl(Inline)]
        public static implicit operator (ulong? m, ulong n, NumericKind t)(NatIdentity src)
            => (src.M, src.N, src.T);

        [MethodImpl(Inline)]
        public NatIdentity(ulong? m, ulong n, NumericKind t)
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
        public bool Equals(NatIdentity src)
            => M == src.M
            && N == src.N
            && T == src.T;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(M,N);

        public override bool Equals(object src)
            => src is NatIdentity id && Equals(id);
    }
}