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
        public readonly struct TwoByteDisplacement : ITwoByteDisplacement
        {
            public Cell16 Value {get;}

            [MethodImpl(Inline)]
            public TwoByteDisplacement(Cell16 value)
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

            public static TwoByteDisplacement Empty
                => default;
        }

    }
}
