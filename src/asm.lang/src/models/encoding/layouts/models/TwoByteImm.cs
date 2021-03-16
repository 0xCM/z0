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
        public readonly struct TwoByteImm : ITwoByteImm
        {
            public Cell16 Value {get;}

            [MethodImpl(Inline)]
            public TwoByteImm(Cell16 value)
            {
                Value = value;
            }
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Value == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static TwoByteImm Empty
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TwoByteImm(ushort src)
                => new TwoByteImm(src);

            [MethodImpl(Inline)]
            public static implicit operator TwoByteImm(Cell16 src)
                => new TwoByteImm(src);
        }
    }
}