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
        public readonly struct OneByteDisplacement : IOneByteDisplacement
        {
            public Cell8 Value {get;}

            [MethodImpl(Inline)]
            public OneByteDisplacement(Cell8 value)
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

            public static OneByteDisplacement Empty
                => default;
        }
    }
}