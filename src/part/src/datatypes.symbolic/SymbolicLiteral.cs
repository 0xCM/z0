//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a symbolized literal
    /// </summary>
    [Record(TableId)]
    public struct SymbolicLiteral : IComparableRecord<SymbolicLiteral>
    {
        public const string TableId = "symbolic.literals";

        /// <summary>
        /// The component that defines the literal
        /// </summary>
        public Name Component;

        /// <summary>
        /// The literal's declaring type
        /// </summary>
        public Identifier Type;

        /// <summary>
        /// The container-relative declaration order of the literal
        /// </summary>
        public ushort Position;

        /// <summary>
        /// The literal name
        /// </summary>
        public Identifier Name;

        /// <summary>
        /// A global identifier
        /// </summary>
        public Name UniqueName;

        /// <summary>
        /// The literal's primitive classifier
        /// </summary>
        public ClrPrimalKind DataType;

        /// <summary>
        /// The encoded literal, possibly an invariant address to a string resource
        /// </summary>
        public ulong EncodedValue;

        [MethodImpl(Inline)]
        public int CompareTo(SymbolicLiteral src)
            => UniqueName.Content.CompareTo(src.UniqueName);
    }
}