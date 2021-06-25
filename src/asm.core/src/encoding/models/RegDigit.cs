//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpCodeTokens;

    /// <summary>
    /// Represents a register digit 0..7 that occurs within an op code expression
    /// </summary>
    public readonly struct RegDigit
    {
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
        public static implicit operator RegDigit(RegExtKind src)
            => new RegDigit((byte)src);

        [MethodImpl(Inline)]
        public static explicit operator byte(RegDigit src)
            => src.Value;
    }
}