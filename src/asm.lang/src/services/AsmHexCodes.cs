//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly struct AsmHexCodes
    {
        public static RexPrefixKind RexW => RexPrefixKind.W;

        public static RexPrefixKind RexR => RexPrefixKind.R;

        public static RexPrefixKind RexX => RexPrefixKind.X;

        public static RexPrefixKind RexB => RexPrefixKind.B;

        public static RegDigit rd0 => RegDigitCode.rd0;

        public static RegDigit rd1 => RegDigitCode.rd1;

        public static RegDigit rd2 => RegDigitCode.rd2;

        public static RegDigit rd3 => RegDigitCode.rd3;

        public static RegDigit rd4 => RegDigitCode.rd4;

        public static RegDigit rd5 => RegDigitCode.rd5;

        public static RegDigit rd6 => RegDigitCode.rd6;

        public static RegDigit rd7 => RegDigitCode.rd7;
    }
}