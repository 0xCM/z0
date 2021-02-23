//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodes
    {
        /// <summary>
        /// Represents a register digit 0..7 that occurs within an op code expression
        /// </summary>
        public readonly struct RegDigit : IOpCodeModel<RegDigit>
        {
            public uint3 Value {get;}

            [MethodImpl(Inline)]
            public RegDigit(uint3 value)
                => Value = value;

            public RegDigitCode Kind
            {
                [MethodImpl(Inline)]
                get => (RegDigitCode)(byte)Value;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegDigit(uint3 src)
                => new RegDigit(src);

            [MethodImpl(Inline)]
            public static implicit operator RegDigit(RegDigitCode src)
                => new RegDigit((byte)src);

            [MethodImpl(Inline)]
            public static implicit operator RegDigit(byte src)
                => new RegDigit(src);
        }
    }
}