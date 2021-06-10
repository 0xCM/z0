//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using T = AsmOpCodeTokens;

    /// <summary>
    /// Represents a register digit 0..7 that occurs within an op code expression
    /// </summary>
    public readonly struct RegDigit
    {
        public static RegDigit r0 => T.RegDigit.r0;

        public static RegDigit r1 => T.RegDigit.r1;

        public static RegDigit r2 => T.RegDigit.r2;

        public static RegDigit r3 => T.RegDigit.r3;

        public static RegDigit r4 => T.RegDigit.r4;

        public static RegDigit r5 => T.RegDigit.r5;

        public static RegDigit r6 => T.RegDigit.r6;

        public static RegDigit r7 => T.RegDigit.r7;

        public uint3 Value {get;}

        [MethodImpl(Inline)]
        public RegDigit(uint3 value)
            => Value = value;

        [MethodImpl(Inline)]
        public RegDigit(byte value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator RegDigit(uint3 src)
            => new RegDigit(src);

        [MethodImpl(Inline)]
        public static implicit operator RegDigit(byte src)
            => new RegDigit(src);

        [MethodImpl(Inline)]
        public static implicit operator RegDigit(T.RegDigit src)
            => new RegDigit((byte)src);
    }
}