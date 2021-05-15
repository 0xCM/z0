//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a symbolized literal
    /// </summary>
    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct SymLiteral : IRecord<SymLiteral>
    {
        public const string TableId = "symbolic.literals";

        public const byte FieldCount = 9;

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
        /// A unique identifier
        /// </summary>
        public SymIdentity Identity;

        /// <summary>
        /// The literal's primitive classifier
        /// </summary>
        public ClrPrimalKind DataType;

        /// <summary>
        /// The encoded literal, possibly an invariant address to a string resource
        /// </summary>
        public ulong ScalarValue;

        /// <summary>
        /// The symbol, if so attributed, otherwise, the identifier
        /// </summary>
        public SymExpr Symbol;

        /// <summary>
        /// The meaning of the literal, if available; otherwise empty
        /// </summary>
        public TextBlock Description;
    }
}