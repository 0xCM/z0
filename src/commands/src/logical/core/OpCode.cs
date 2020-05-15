//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OpCode
    {        
        public readonly byte Value;

        [MethodImpl(Inline)]
        public static OpCode Define(byte src)
            => new OpCode(src);

        [MethodImpl(Inline)]
        public static implicit operator OpCode(byte src)
            => new OpCode(src);

        [MethodImpl(Inline)]
        public OpCode(byte value)
        {
            Value = value;

        }

        public string Format()
            => Value.FormatHex(true, false);

        public override string ToString()
            => Format();       
    }

}