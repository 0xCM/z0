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
        public readonly struct FourByteDisplacement : IFourByteDisplacement
        {
            public Cell32 Value {get;}

            [MethodImpl(Inline)]
            public FourByteDisplacement(Cell32 value)
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

            public string Format()
                => Value.Format();

            public override string ToString()
                => Format();

            public static FourByteDisplacement Empty
                => default;
        }
    }
}