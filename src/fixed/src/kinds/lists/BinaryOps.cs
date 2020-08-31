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
        /// Specifies a fixed binary operator defined over 8-bit operands
        /// </summary>
        public static FixedOpKind<W8,FixedCell8,BinaryOp8> BinaryOp8 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 16-bit operands
        /// </summary>
        public static FixedOpKind<W16,FixedCell16,BinaryOp16> BinaryOp16 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 32-bit operands
        /// </summary>
        public static FixedOpKind<W32,Fixed32,BinaryOp32> BinaryOp32 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 64-bit operands
        /// </summary>
        public static FixedOpKind<W64,FixedCell64,BinaryOp64> BinaryOp64 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 128-bit operands
        /// </summary>
        public static FixedOpKind<W128,FixedCell128,BinaryOp128> BinaryOp128 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 256-bit operands
        /// </summary>
        public static FixedOpKind<W256,FixedCell256,BinaryOp256> BinaryOp256 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 512-bit operands
        /// </summary>
        public static FixedOpKind<W512,FixedCell512,BinaryOp512> BinaryOp512 => default;
    }
}
