//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a version schema that supports 2, 3 or 4 32-bit segments
    /// </summary>
    public readonly struct VersionInfo : IDataTypeComparable<VersionInfo>
    {
        /// <summary>
        /// The first segment value
        /// </summary>
        public uint A {get;}

        /// <summary>
        /// The second segment value
        /// </summary>
        public uint B {get;}

        /// <summary>
        /// The third segment value, or 0 if none
        /// </summary>
        public uint C {get;}

        /// <summary>
        /// The fourth segment value, or 0 if none
        /// </summary>
        public uint D {get;}

        [MethodImpl(Inline)]
        public VersionInfo(uint a, uint b, uint c = 0, uint d = 0)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public string Format()
            => string.Format(RP.SlotDot4, A, B, C, D);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(VersionInfo src)
            => A == src.A && B == src.B && C == src.C && D == src.D;

        public override bool Equals(object src)
            => src is VersionInfo other && Equals(other);

        public override int GetHashCode()
            => (int)alg.hash.calc(A,B,C,D);

        public int CompareTo(VersionInfo src)
        {
            if (A != src.A)
                return A.CompareTo(src.A);

            if (B != src.B)
                return B.CompareTo(src.B);

            if (C != src.C)
                return C.CompareTo(src.C);

            return D.CompareTo(src.D);
        }

        [MethodImpl(Inline)]
        public static bool operator ==(VersionInfo lhs, VersionInfo rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(VersionInfo lhs, VersionInfo rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public static bool operator <(VersionInfo lhs, VersionInfo rhs)
            => lhs.CompareTo(rhs) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(VersionInfo lhs, VersionInfo rhs)
            => lhs.CompareTo(rhs) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(VersionInfo lhs, VersionInfo rhs)
            => rhs < lhs;

        [MethodImpl(Inline)]
        public static bool operator >=(VersionInfo lhs, VersionInfo rhs)
            => rhs <= lhs;

        [MethodImpl(Inline)]
        public static implicit operator VersionInfo(ConstPair<uint> src)
            => new VersionInfo(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator VersionInfo(Pair<uint> src)
            => new VersionInfo(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator VersionInfo(ConstTriple<uint> src)
            => new VersionInfo(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public static implicit operator VersionInfo(ConstQuad<uint> src)
            => new VersionInfo(src.First, src.Second, src.Third, src.Fourth);

        [MethodImpl(Inline)]
        public static implicit operator VersionInfo(Version src)
            => new VersionInfo((uint)src.Major, (uint)src.Minor, (uint)src.MajorRevision, (uint)src.MinorRevision);
    }
}