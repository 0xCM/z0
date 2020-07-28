//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    /// <summary>
    /// Represents the version of a DLL.
    /// </summary>
    public readonly struct DllVersion : IEquatable<DllVersion>, IComparable<DllVersion>
    {
        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'A'.
        /// </summary>
        public readonly int Major { get; }

        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'B'.
        /// </summary>
        public readonly int Minor { get; }

        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'C'.
        /// </summary>
        public readonly int Revision { get; }

        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'D'.
        /// </summary>
        public readonly int Patch { get; }

        public DllVersion(int major, int minor, int revision, int patch)
        {
            Major = major;
            Minor = minor;
            Revision = revision;
            Patch = patch;
        }

        /// <inheritdoc/>
        public bool Equals(DllVersion other)
        {
            return Major == other.Major && Minor == other.Minor && Revision == other.Revision && Patch == other.Patch;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is DllVersion other && Equals(other);

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Major;
                hashCode = (hashCode * 397) ^ Minor;
                hashCode = (hashCode * 397) ^ Revision;
                hashCode = (hashCode * 397) ^ Patch;
                return hashCode;
            }
        }

        /// <inheritdoc/>
        public int CompareTo(DllVersion other)
        {
            if (Major != other.Major)
                return Major.CompareTo(other.Major);

            if (Minor != other.Minor)
                return Minor.CompareTo(other.Minor);

            if (Revision != other.Revision)
                return Revision.CompareTo(other.Revision);

            return Patch.CompareTo(other.Patch);
        }

        /// <summary>
        /// To string.
        /// </summary>
        /// <returns>The A.B.C.D version prepended with 'v'.</returns>
        public override string ToString()
        {
            return $"{Major}.{Minor}.{Revision}.{Patch}";
        }

        public static bool operator ==(DllVersion left, DllVersion right) => left.Equals(right);

        public static bool operator !=(DllVersion left, DllVersion right) => !(left == right);

        public static bool operator <(DllVersion left, DllVersion right) => left.CompareTo(right) < 0;

        public static bool operator <=(DllVersion left, DllVersion right) => left.CompareTo(right) <= 0;

        public static bool operator >(DllVersion left, DllVersion right) => right < left;

        public static bool operator >=(DllVersion left, DllVersion right) => right <= left;
    }
}