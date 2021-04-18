//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines a symbolized literal
    /// </summary>
    [Record(TableId)]
    public struct SymLiteral : IRecord<SymLiteral>
    {
        public const string TableId = "symbolic.literals";

        public const byte FieldCount = 8;

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
        /// The literal's primitive classifier
        /// </summary>
        public ClrPrimalKind DataType;

        /// <summary>
        /// The encoded literal, possibly an invariant address to a string resource
        /// </summary>
        public ulong EncodedValue;

        /// <summary>
        /// The symbol, if so attributed, otherwise, the identifier
        /// </summary>
        public TextBlock Symbol;

        /// <summary>
        /// The meaning of the literal, if available; otherwise empty
        /// </summary>
        public TextBlock Description;
    }
}