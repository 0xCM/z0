//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    partial class Seed
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const string Kernel32 = "kernel32.dll";

        public const NumericKind Numeric64 = NumericKind.Width64;

        public const NumericKind Numeric16x32x64 = NumericKind.Width16 | NumericKind.Width32 | NumericKind.Width64;

        public const NumericKind Numeric32x64 = NumericKind.Width32 | NumericKind.Width64;

        /// <summary>
        /// Species the base2 singleton representative
        /// </summary>
        public static Base2 base2 => default;

        /// <summary>
        /// Species the base8 singleton representative
        /// </summary>
        public static Base3 base3 => default;

        /// <summary>
        /// Species the base8 singleton representative
        /// </summary>
        public static Base8 base8 => default;

        /// <summary>
        /// Species the base10 singleton representative
        /// </summary>
        public static Base10 base10 => default;

        /// <summary>
        /// Species the base16 singleton representative
        /// </summary>
        public static Base16 base16 => default;

    }
}