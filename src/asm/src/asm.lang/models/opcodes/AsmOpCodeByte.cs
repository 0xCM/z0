//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodeModel
    {
        /// <summary>
        /// Represents a literal byte value occurring within an op code
        /// </summary>
        public readonly struct OpCodeByte : IOpCodeModel<OpCodeByte>
        {
            public Hex8 Value {get;}

            [MethodImpl(Inline)]
            public OpCodeByte(Hex8 value)
            {
                Value = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator OpCodeByte(Hex8 src)
                => new OpCodeByte(src);

            [MethodImpl(Inline)]
            public static implicit operator OpCodeByte(byte src)
                => new OpCodeByte(src);
        }
    }
}