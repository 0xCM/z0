//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp32
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public Disp32(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp32(uint src)
            => new Disp32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Disp32 src)
            => src.Value;
    }
}