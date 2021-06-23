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
    public readonly struct RegExtension
    {
        public uint3 Value {get;}

        [MethodImpl(Inline)]
        public RegExtension(uint3 value)
            => Value = value;

        [MethodImpl(Inline)]
        public RegExtension(byte value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator RegExtension(uint3 src)
            => new RegExtension(src);

        [MethodImpl(Inline)]
        public static implicit operator RegExtension(byte src)
            => new RegExtension(src);

        [MethodImpl(Inline)]
        public static implicit operator RegExtension(RegExtKind src)
            => new RegExtension((byte)src);

        [MethodImpl(Inline)]
        public static explicit operator byte(RegExtension src)
            => src.Value;
    }
}