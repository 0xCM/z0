//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp8
    {
        public byte Value {get;}

        [MethodImpl(Inline)]
        public Disp8(byte value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp8(byte src)
            => new Disp8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(Disp8 src)
            => src.Value;
    }
}