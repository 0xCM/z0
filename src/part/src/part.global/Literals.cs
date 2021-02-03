//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using DW = DataWidth;
    using Z = Zero;
    using CC = System.Runtime.InteropServices.CallingConvention;

    partial struct Part
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const string EmptyString = "";

        /// <summary>
        /// An abbreviation for the ridiculously long "StringComparison.InvariantCultureIgnoreCase"
        /// </summary>
        public const StringComparison NoCase = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>
        /// An abbreviation for the somewhat verbose "StringComparison.InvariantCulture"
        /// </summary>
        public const StringComparison Cased = StringComparison.InvariantCulture;

        /// <summary>
        /// The end-of-line escape sequence
        /// </summary>
        public const string Eol = Chars.Eol;

        /// <summary>
        /// The default delimiter to use when formatting structured text
        /// </summary>
        public const char FieldDelimiter = Chars.Pipe;

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const char Space = ' ';

        /// <summary>
        /// Evidence of absence
        /// </summary>
        public const byte AsciNone = (byte)AsciCharCode.Null;

        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;

        /// <summary>
        /// Specifies the widths of system-supported primal numeric data types
        /// </summary>
        public const DW NumericWidths = DW.W8 | DW.W16 | DW.W32 | DW.W64;

        /// <summary>
        /// Specifies the <see cref='CC.StdCall'/> calling convention where the
        /// callee is responsible for stack management
        /// </summary>
        /// <remarks>
        /// This is the default PInvoke convention
        /// </remarks>
        public const CC StdCall = CC.StdCall;

        /// <summary>
        /// Specifies the <see cref='CC.Cdecl'/> calling convention where the caller
        /// is responsible for stack management
        /// </summary>
        /// <remarks>
        /// According to the runtime documentation, "This enables calling functions with varargs, which
        /// makes it appropriate to use for methods that accept a variable number of parameters,
        /// such as Printf".
        /// </remarks>
        public const CC Cdecl = CC.Cdecl;

        /// <summary>
        /// Specifies the <see cref='CC.ThisCall'/> calling convention where first argument is <see cref='this'/>
        /// and is placed in ECX/RCX
        /// </summary>
        public const CC ThisCall = CC.ThisCall;

        /// <summary>
        /// Canonical return value for search operation that returns a nonnegative value upon success
        /// </summary>
        public const int NotFound = -1;

        /// <summary>
        /// One, presented as an 8-bit signed integer
        /// </summary>
        public const sbyte One8i = 1;

        /// <summary>
        /// One, presented as an 8-bit unsigned integer
        /// </summary>
        public const byte One8u = 1;

        /// <summary>
        /// One, presented as a 16-bit signed integer
        /// </summary>
        public const short One16i = 1;

        /// <summary>
        /// One, presented as a 16-bit unsigned integer
        /// </summary>
        public const ushort One16u = 1;

        /// <summary>
        /// One, presented as a 32-bit signed integer
        /// </summary>
        public const int One32i = 1;

        /// <summary>
        /// One, presented as a 32-bit unsigned integer
        /// </summary>
        public const uint One32u = 1;

        /// <summary>
        /// One, presented as a 64-bit signed integer
        /// </summary>
        public const long One64i = 1;

        /// <summary>
        /// One, presented as a 64-bit unsigned integer
        /// </summary>
        public const ulong One64u = 1;

        /// <summary>
        /// One, presented as a 32-bit floating-point number
        /// </summary>
        public const float One32f = 1;

        /// <summary>
        /// One, presented as a 64-bit floating-point number
        /// </summary>
        public const double One64f = 1;

        /// <summary>
        /// One, presented as a 128-bit floating-point number
        /// </summary>
        public const decimal One128f = 0m;


        /// <summary>
        /// The zero-value for a string
        /// </summary>
        public const string zS = Z.zS;

        /// <summary>
        /// Uppercase letter classifier accessor
        /// </summary>
        public static UpperCased UpperCase => default;

        /// <summary>
        /// Lowercase letter classifier accessor
        /// </summary>
        public static LowerCased LowerCase => default;

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