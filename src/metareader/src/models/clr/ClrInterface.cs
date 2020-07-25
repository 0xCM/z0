//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ClrDataModel
    {
        /// <summary>
        /// An interface implementation in the target process.
        /// </summary>
        public sealed class ClrInterface : IEquatable<ClrInterface>
        {
            /// <summary>
            /// Gets the typename of the interface.
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Gets the interface that this interface inherits from.
            /// </summary>
            public ClrInterface BaseInterface { get; }

            /// <summary>
            /// Display string for this interface.
            /// </summary>
            /// <returns>Display string for this interface.</returns>
            public override string ToString() 
                => Name;

            public ClrInterface(string name, ClrInterface baseInterface)
            {
                Name = name;
                BaseInterface = baseInterface;
            }

            /// <summary>
            /// Equals override.
            /// </summary>
            /// <param name="obj">Object to compare to.</param>
            /// <returns>True if this interface equals another.</returns>
            public override bool Equals(object obj) => Equals(obj as ClrInterface);

            public bool Equals(ClrInterface other)
            {
                if (ReferenceEquals(this, other))
                    return true;

                if (other is null)
                    return false;

                return Name == other.Name && BaseInterface == other.BaseInterface;
            }

            /// <summary>
            /// GetHashCode override.
            /// </summary>
            /// <returns>A hashcode for this object.</returns>
            public override int GetHashCode()
            {
                int hashCode = 0;

                if (Name != null)
                    hashCode ^= Name.GetHashCode();

                if (BaseInterface != null)
                    hashCode ^= BaseInterface.GetHashCode();

                return hashCode;
            }

            public static bool operator ==(ClrInterface left, ClrInterface right)
            {
                if (right is null)
                    return left is null;

                return right.Equals(left);
            }

            public static bool operator !=(ClrInterface left, ClrInterface right) => !(left == right);
        }
    }
}