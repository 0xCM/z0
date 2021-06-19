//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp16
    {
        public ushort Value {get;}

        [MethodImpl(Inline)]
        public Disp16(ushort value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp16(ushort src)
            => new Disp16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(Disp16 src)
            => src.Value;
    }
}