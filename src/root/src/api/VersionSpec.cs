//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a version schema that supports 2, 3 or 4 32-bit segments
    /// </summary>
    public readonly struct VersionSpec : IDataTypeComparable<VersionSpec>
    {
        /// <summary>
        /// The most-significant segment value
        /// </summary>
        public readonly uint A;

        /// <summary>
        /// The secondary segment value
        /// </summary>
        public readonly uint B;

        /// <summary>
        /// The tertiary segment value, or 0 if none
        /// </summary>
        public readonly uint C;

        /// <summary>
        /// The least-significant segment value, or 0 if none
        /// </summary>
        public readonly uint D;

        [MethodImpl(Inline)]
        public VersionSpec(uint a, uint b, uint c = 0, uint d = 0)
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
        public bool Equals(VersionSpec src)
            => A == src.A && B == src.B && C == src.C && D == src.D;

        public override bool Equals(object src)
            => src is VersionSpec other && Equals(other);

        public override int GetHashCode()
            => (int)FastHash.combine(FastHash.combine(A,B),FastHash.combine(C,D));

        public int CompareTo(VersionSpec src)
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
        public static bool operator ==(VersionSpec lhs, VersionSpec rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(VersionSpec lhs, VersionSpec rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public static bool operator <(VersionSpec lhs, VersionSpec rhs)
            => lhs.CompareTo(rhs) < 0;

        [MethodImpl(Inline)]
        public static bool operator <=(VersionSpec lhs, VersionSpec rhs)
            => lhs.CompareTo(rhs) <= 0;

        [MethodImpl(Inline)]
        public static bool operator >(VersionSpec lhs, VersionSpec rhs)
            => rhs < lhs;

        [MethodImpl(Inline)]
        public static bool operator >=(VersionSpec lhs, VersionSpec rhs)
            => rhs <= lhs;

        [MethodImpl(Inline)]
        public static implicit operator VersionSpec((uint a, uint b) src)
            => new VersionSpec(src.a, src.b);

        [MethodImpl(Inline)]
        public static implicit operator VersionSpec(Version src)
            => new VersionSpec((uint)src.Major, (uint)src.Minor, (uint)src.MajorRevision, (uint)src.MinorRevision);
    }
}