//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct LayoutComponents
    {
        public readonly struct Immediate : IImm
        {
            Cell32 Value {get;}

            public DataWidth Width {get;}

            [MethodImpl(Inline)]
            public Immediate(Cell8 value)
            {
                Value = value;
                Width = DataWidth.W8;
            }

            [MethodImpl(Inline)]
            public Immediate(Cell16 value)
            {
                Value = value;
                Width = DataWidth.W16;
            }

            [MethodImpl(Inline)]
            public Immediate(Cell32 value)
            {
                Value = value;
                Width = DataWidth.W32;
            }

            public ReadOnlySpan<byte> Data
            {
                [MethodImpl(Inline)]
                get => memory.slice(memory.bytes(Value),0, (byte)Width/8);
            }

            public bool IsEmpty
                => Value == 0;

            [MethodImpl(Inline)]
            public static implicit operator Immediate(OneByteImm src)
                => new Immediate(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator Immediate(TwoByteImm src)
                => new Immediate(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator Immediate(FourByteImm src)
                => new Immediate(src.Value);

            [MethodImpl(Inline)]
            public static implicit operator OneByteImm(Immediate src)
                => new OneByteImm((Cell8)src.Value);

            [MethodImpl(Inline)]
            public static implicit operator TwoByteImm(Immediate src)
                => new TwoByteImm((Cell16)src.Value);

            [MethodImpl(Inline)]
            public static implicit operator FourByteImm(Immediate src)
                => new FourByteImm(src.Value);
        }
    }
}