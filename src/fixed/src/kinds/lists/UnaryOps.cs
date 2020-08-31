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
        /// Specifies a fixed unary operator defined over an 8-bit operand
        /// </summary>
        public static FixedOpKind<W8,FixedCell8,UnaryOp8> UnaryOp8 => default;

        /// <summary>
        /// Specifies a fixed unary operator defined over a 16-bit operand
        /// </summary>
        public static FixedOpKind<W16,FixedCell16,UnaryOp16> UnaryOp16 => default;

        /// <summary>
        /// Specifies a fixed unary operator defined over a 32-bit operand
        /// </summary>
        public static FixedOpKind<W32,Fixed32,UnaryOp32> UnaryOp32 => default;

        /// <summary>
        /// Specifies a fixed unary operator defined over a 64-bit operand
        /// </summary>
        public static FixedOpKind<W64,FixedCell64,UnaryOp64> UnaryOp64 => default;

        /// <summary>
        /// Specifies a fixed unary operator defined over a 128-bit operand
        /// </summary>
        public static FixedOpKind<W128,FixedCell128,UnaryOp128> UnaryOp128 => default;

        /// <summary>
        /// Specifies a fixed unary operator defined over a 256-bit operand
        /// </summary>
        public static FixedOpKind<W256,FixedCell256,UnaryOp256> UnaryOp256 => default;

        /// <summary>
        /// Specifies a fixed unary operator defined over a 512-bit operand
        /// </summary>
        public static FixedOpKind<W512,FixedCell512,UnaryOp512> UnaryOp512 => default;
    }
}