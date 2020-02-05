//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    /// <summary>
    /// Defines a parition over primal numeric types: signed ints, unsigned ints and floating-point
    /// </summary>
    public enum NumericClass : uint
    {
        None = 0,

        /// <summary>
        /// A signed integral type
        /// </summary>
        Signed = 1u << 31,

        /// <summary>
        /// A floating-point type
        /// </summary>
        Float = 1u << 30,

        /// <summary>
        /// An unsigned integral type
        /// </summary>
        Unsigned = 1u << 29,
    }

    partial class RootKindExtensions
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericClass src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this NumericClass src)
            => src == 0;

        [MethodImpl(Inline)]
        public static bool IsSigned(this NumericClass src)
            => src == NumericClass.Signed;

        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NumericClass src)
            => src == NumericClass.Unsigned;

        [MethodImpl(Inline)]
        public static bool IsFloat(this NumericClass src)
            => src == NumericClass.Float;

        [MethodImpl(Inline)]
        public static NumericIndicator ToNumericIndicator(this NumericClass src)
            =>    src.IsSigned() ? NumericIndicator.Signed 
                : src.IsUnsigned() ? NumericIndicator.Unsigned 
                : src.IsFloat() ? NumericIndicator.Float 
                : NumericIndicator.None;

    }
}