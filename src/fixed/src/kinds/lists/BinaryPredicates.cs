//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    partial class FixedOpKinds
    {
        /// <summary>
        /// Specifies a fixed binary predicate defined over 8-bit operands
        /// </summary>
        public static FixedOpKind<W8,Fixed8,BinaryPredicate8> BinaryPredicate8 => default;

        /// <summary>
        /// Specifies a fixed binary predicate defined over 16-bit operands
        /// </summary>
        public static FixedOpKind<W16,Fixed16,BinaryPredicate16> BinaryPredicate16 => default;

        /// <summary>
        /// Specifies a fixed binary predicate defined over 32-bit operands
        /// </summary>
        public static FixedOpKind<W32,Fixed32,BinaryPredicate32> BinaryPredicate32 => default;

        /// <summary>
        /// Specifies a fixed binary predicate defined over 64-bit operands
        /// </summary>
        public static FixedOpKind<W64,Fixed64,BinaryPredicate64> BinaryPredicate64 => default;

        /// <summary>
        /// Specifies a fixed binary predicate defined over 128-bit operands
        /// </summary>
        public static FixedOpKind<W128,Fixed128,BinaryPredicate128> BinaryPredicate128 => default;

        /// <summary>
        /// Specifies a fixed binary predicate defined over 256-bit operands
        /// </summary>
        public static FixedOpKind<W256,Fixed256,BinaryPredicate256> BinaryPredicate256 => default;

        /// <summary>
        /// Specifies a fixed binary predicate defined over 512-bit operands
        /// </summary>
        public static FixedOpKind<W512,Fixed512,BinaryPredicate512> BinaryPredicate512 => default;
    }
}