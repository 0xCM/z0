//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a symbol
    /// </summary>
    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct SymSpec : IRecord<SymSpec>
    {
        public const string TableId = "symspecs";

        /// <summary>
        /// A 0-based surrogate key
        /// </summary>
        public uint Index;

        /// <summary>
        /// The classifier name
        /// </summary>
        public Identifier Kind;

        /// <summary>
        /// The symbol name
        /// </summary>
        public Identifier Name;

         /// <summary>
        /// The unevaluated symbol value
        /// </summary>
        public SymExpr Expression;

        /// <summary>
        /// The evaluated symbol value
        /// </summary>
        public dynamic Value;

        /// <summary>
        /// The symbol meaning
        /// </summary>
        public TextBlock Description;

        /// <summary>
        /// The type-system value domain
        /// </summary>
        public LiteralKind ValueKind;
    }
}