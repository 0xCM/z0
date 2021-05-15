//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a symbolized literal
    /// </summary>
    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct SymLiteral : IRecord<SymLiteral>
    {
        public const string TableId = "symbolic.literals";

        public const byte FieldCount = 10;

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
        public Hex64 ScalarValue;

        /// <summary>
        /// The symbol, if so attributed, otherwise, the identifier
        /// </summary>
        public SymExpr Symbol;

        /// <summary>
        /// The meaning of the literal, if available; otherwise empty
        /// </summary>
        public TextBlock Description;

        /// <summary>
        /// Indicates whether the literal is occluded
        /// </summary>
        public bool Hidden;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{14, 14, 10, 20, 80, 12, 12, 22, 48, 10};
    }
}