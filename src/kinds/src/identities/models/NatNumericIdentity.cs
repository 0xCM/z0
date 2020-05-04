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
    /// Defines identity for a pair NxT or MxNxT where M and N are natural types and T is numeric
    /// </summary>
    public readonly struct NatNumericIdentity : IIdentification<NatNumericIdentity>
    {        
        public static NatNumericIdentity Empty => default;

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
            var numeric = NumericParser.create<ulong>();
            var indicator = (NumericIndicator)kind.Last();
            var w =  (NumericWidth)numeric.Parse(kind.TrimEnd(kind.Last())).ValueOrDefault();
            return ((NumericWidth)w).ToNumericKind(indicator);
        }

        public static NatNumericIdentity Parse(string src)
        {
            var numeric = NumericParser.create<ulong>();
            var parts = text.split(src, IDI.SegSep);
            if(parts.Length == 3)
            {
                var m = numeric.Parse(parts[0]).ValueOrDefault();
                var n = numeric.Parse(parts[1]).ValueOrDefault();
                var kind = parts[2];
                if(kind.Length > 0)
                {
                    var nk = ParseNumericKind(kind);
                    return new NatNumericIdentity(m, n, nk);
                }
            }
            else if(parts.Length == 2)
            {
                var n = numeric.Parse(parts[0]).ValueOrDefault();
                var kind = parts[1];
                if(kind.Length > 0)
                {
                    var nk = ParseNumericKind(kind);
                    return new NatNumericIdentity(null, n, nk);
                }
            
            }
            return Empty;
        }

        public Option<Type> MType => M.TryMap(m => NativeNaturals.FindType(m)).Value; 

        public Type NType => NativeNaturals.FindType(N).Require();

        public NumericWidth NumericWidth => (NumericWidth)T.Width();

        public string IdentityText 
            => M != null 
               ? $"{M}{IDI.SegSep}{N}{IDI.SegSep}{T.Format()}"
               : $"{N}{IDI.SegSep}{T.Format()}";

        public static bool operator ==(NatNumericIdentity d1, NatNumericIdentity d2)
            => d1.Equals(d2);

        public static bool operator !=(NatNumericIdentity d1, NatNumericIdentity d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public static implicit operator NatNumericIdentity((ulong? m, ulong n, NumericKind t) src)
            => new NatNumericIdentity(src.m,src.n,src.t);

        [MethodImpl(Inline)]
        public static implicit operator (ulong? m, ulong n, NumericKind t)(NatNumericIdentity src)
            => (src.M, src.N, src.T);

        [MethodImpl(Inline)]
        public NatNumericIdentity(ulong? m, ulong n, NumericKind t)
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
            => IdentityText;

        [MethodImpl(Inline)]
        public bool Equals(NatNumericIdentity src)
            => M == src.M 
            && N == src.N 
            && T == src.T;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(M,N);
        
        public override bool Equals(object src)
            => src is NatNumericIdentity id && Equals(id);
    }
}