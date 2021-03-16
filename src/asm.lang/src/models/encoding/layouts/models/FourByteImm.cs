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
        public readonly struct FourByteImm : IFourByteImm
        {
            public Cell32 Value {get;}

            [MethodImpl(Inline)]
            public FourByteImm(Cell32 value)
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

            public static FourByteImm Empty
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FourByteImm(uint src)
                => new FourByteImm(src);

            [MethodImpl(Inline)]
            public static implicit operator FourByteImm(Cell32 src)
                => new FourByteImm(src);
        }
    }
}