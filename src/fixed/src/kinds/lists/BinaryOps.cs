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
        public static FixedOpKind<W8,Fixed8,BinaryOp8> BinaryOp8 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 16-bit operands
        /// </summary>
        public static FixedOpKind<W16,Fixed16,BinaryOp16> BinaryOp16 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 32-bit operands
        /// </summary>
        public static FixedOpKind<W32,Fixed32,BinaryOp32> BinaryOp32 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 64-bit operands
        /// </summary>
        public static FixedOpKind<W64,Fixed64,BinaryOp64> BinaryOp64 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 128-bit operands
        /// </summary>
        public static FixedOpKind<W128,Fixed128,BinaryOp128> BinaryOp128 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 256-bit operands
        /// </summary>
        public static FixedOpKind<W256,Fixed256,BinaryOp256> BinaryOp256 => default;

        /// <summary>
        /// Specifies a fixed binary operator defined over 512-bit operands
        /// </summary>
        public static FixedOpKind<W512,Fixed512,BinaryOp512> BinaryOp512 => default;
    }
}
