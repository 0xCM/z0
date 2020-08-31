//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class FixedOpKinds
    {
        /// <summary>
        /// Specifies a fixed unary predicate defined over an 8-bit operand
        /// </summary>
        public static FixedOpKind<W8,FixedCell8,UnaryPredicate8> UnaryPredicate8 => default;

        /// <summary>
        /// Specifies a fixed unary predicate defined over a 16-bit operand
        /// </summary>
        public static FixedOpKind<W16,FixedCell16,UnaryPredicate16> UnaryPredicate16 => default;

        /// <summary>
        /// Specifies a fixed unary predicate defined over a 32-bit operand
        /// </summary>
        public static FixedOpKind<W32,Fixed32,UnaryPredicate32> UnaryPredicate32 => default;

        /// <summary>
        /// Specifies a fixed unary predicate defined over a 64-bit operand
        /// </summary>
        public static FixedOpKind<W64,FixedCell64,UnaryPredicate64> UnaryPredicate64 => default;

        /// <summary>
        /// Specifies a fixed unary predicate defined over a 128-bit operand
        /// </summary>
        public static FixedOpKind<W128,FixedCell128,UnaryPredicate128> UnaryPredicate128 => default;

        /// <summary>
        /// Specifies a fixed unary predicate defined over a 256-bit operand
        /// </summary>
        public static FixedOpKind<W256,FixedCell256,UnaryPredicate256> UnaryPredicate256 => default;

        /// <summary>
        /// Specifies a fixed unary predicate defined over a 512-bit operand
        /// </summary>
        public static FixedOpKind<W512,FixedCell512,UnaryPredicate512> UnaryPredicate512 => default;
    }
}