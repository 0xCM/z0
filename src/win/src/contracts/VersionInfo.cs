//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Represents the version of a DLL.
    /// </summary>
    public readonly struct VersionInfo : IEquatable<VersionInfo>, IComparable<VersionInfo>
    {
        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'A'.
        /// </summary>
        public readonly int Major;

        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'B'.
        /// </summary>
        public readonly int Minor;

        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'C'.
        /// </summary>
        public readonly int Revision;

        /// <summary>
        /// In a version 'A.B.C.D', this field represents 'D'.
        /// </summary>
        public readonly int Patch;

        public VersionInfo(int major, int minor, int revision, int patch)
        {
            Major = major;
            Minor = minor;
            Revision = revision;
            Patch = patch;
        }

        /// <inheritdoc/>
        public bool Equals(VersionInfo other)
            => Major == other.Major && Minor == other.Minor && Revision == other.Revision && Patch == other.Patch;

        /// <inheritdoc/>
        public override bool Equals(object obj)
            => obj is VersionInfo other && Equals(other);

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
        public int CompareTo(VersionInfo other)
        {
            if (Major != other.Major)
                return Major.CompareTo(other.Major);

            if (Minor != other.Minor)
                return Minor.CompareTo(other.Minor);

            if (Revision != other.Revision)
                return Revision.CompareTo(other.Revision);

            return Patch.CompareTo(other.Patch);
        }

        public override string ToString()
            => $"{Major}.{Minor}.{Revision}.{Patch}";

        public static bool operator ==(VersionInfo left, VersionInfo right)
            => left.Equals(right);

        public static bool operator !=(VersionInfo left, VersionInfo right)
            => !(left == right);

        public static bool operator <(VersionInfo left, VersionInfo right)
            => left.CompareTo(right) < 0;

        public static bool operator <=(VersionInfo left, VersionInfo right)
            => left.CompareTo(right) <= 0;

        public static bool operator >(VersionInfo left, VersionInfo right)
            => right < left;

        public static bool operator >=(VersionInfo left, VersionInfo right)
            => right <= left;
    }
}