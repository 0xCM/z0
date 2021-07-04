//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Disp32 : IDisplacement<Disp32,uint>
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public Disp32(uint value)
        {
            Value = value;
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => 32;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp32(uint src)
            => new Disp32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Disp32 src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Disp(Disp32 src)
            => (src.Value,src.Width);

        public static Disp32 Empty
        {
            [MethodImpl(Inline)]
            get => new Disp32(0);
        }
    }
}