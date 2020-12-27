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
    /// Defines a nonparametric enum dataset entry
    /// </summary>
    public struct EnumDatasetEntry
    {
        /// <summary>
        /// The artifact identifier of the defining literal
        /// </summary>
        public ClrToken Id;

        /// <summary>
        /// The defining <see cref='Enum'/> id
        /// </summary>
        public ClrToken EnumId;

        /// <summary>
        /// The 0-based declaration order of the defining literal
        /// </summary>
        public uint Index;

        /// <summary>
        /// The refined primitive value
        /// </summary>
        public variant ScalarValue;

        /// <summary>
        /// The literal name
        /// </summary>
        public StringRef Name;

        /// <summary>
        /// The description, if available
        /// </summary>
        public StringRef Description;

        [MethodImpl(Inline)]
        public EnumDatasetEntry(ClrToken id, ClrToken enumId, uint index, StringRef name, variant scalar, StringRef description)
        {
            Id = id;
            EnumId = enumId;
            Index = index;

            Name = name;
            ScalarValue = scalar;
            Description = description;
        }
    }
}